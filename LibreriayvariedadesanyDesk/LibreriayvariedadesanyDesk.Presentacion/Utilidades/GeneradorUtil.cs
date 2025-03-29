using System.Security.Cryptography;
using System.Text;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using LibreriayvariedadesanyDesk.Repository.Entities;

namespace SVPresentation.Utilidades
{
    public static class GeneradorUtil
    {
        public static string GenerateCode()
        {
            string guid = Guid.NewGuid().ToString("N").Substring(0, 6);
            return guid;
        }
        public static string ConvertToSha256(string Texto)
        {
            //Crear una instancia de SHA256
            using (SHA256 sha256Hash = SHA256.Create())
            {
                //Convertir la cadena de entrada en array de bytes
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(Texto));

                //Construir el string del Hash
                StringBuilder sbuilder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    sbuilder.Append(bytes[i].ToString("x2"));
                }
                return sbuilder.ToString();
            }
        }
        public static byte[] GeneratePDFVenta(Negocio oNegocio, Venta oVenta, Stream ImageLogo)
        {
            QuestPDF.Settings.License = LicenseType.Community;

            var arrayPDF = Document.Create(document => {
                document.Page(page => {
                    page.Margin(30);
                    page.Header().ShowOnce().Row(row => {
                        row.AutoItem().Height(60).Image(ImageLogo, ImageScaling.FitArea);

                        row.RelativeItem().Column(column => {
                            column.Item().AlignCenter().Text(oNegocio.razonSocial).Bold().FontSize(14);
                            column.Item().AlignCenter().Text(oNegocio.direccion).Bold().FontSize(9);
                            column.Item().AlignCenter().Text(oNegocio.telefono).Bold().FontSize(9);
                            column.Item().AlignCenter().Text(oNegocio.email).Bold().FontSize(9);
                            column.Item().AlignCenter().Text(oNegocio.nit).Bold().FontSize(9);
                        });
                        row.ConstantItem(140).Column(col => {
                            col.Item().Background("#634883").Border(1).BorderColor("#634883").AlignCenter().
                            Text("Recibo de Caja").FontColor("#fff");
                            col.Item().Border(1).BorderColor("#634883").AlignCenter().Text(oVenta.numeroVenta);
                        });
                        page.Content().PaddingVertical(15).Column(column1 => {
                            column1.Spacing(10);
                            column1.Item().LineHorizontal(0.5f);

                            column1.Item().Row(row => {
                                row.RelativeItem().Text(text => {
                                    text.Span("Nit: ").SemiBold().FontSize(10);
                                    text.Span(oVenta.Nit).FontSize(10);
                                });
                                row.RelativeItem().Text(text => {
                                    text.Span("Cliente: ").SemiBold().FontSize(10);
                                    text.Span(oVenta.nombreCliente).FontSize(10);
                                });
                            });


                            column1.Item().Row(row => {
                                row.RelativeItem().Text(text => {
                                    text.Span("Fecha emision: ").SemiBold().FontSize(10);
                                    text.Span(oVenta.fechaRegistro).FontSize(10);
                                });
                                row.RelativeItem().Text(text =>
                                {
                                    text.Span("Medio de pago: ").SemiBold().FontSize(10);
                                    text.Span(oVenta.refMedioPago.descripcion).FontSize(10);
                                });
                            });

                            column1.Item().LineHorizontal(0.5f);
                            column1.Item().Table(tabla => {
                                tabla.ColumnsDefinition(columnas => {
                                    columnas.RelativeColumn(3);
                                    columnas.RelativeColumn();
                                    columnas.RelativeColumn();
                                    columnas.RelativeColumn();
                                });

                                tabla.Header(header => {
                                    header.Cell().Background("#634883").Padding(2).Text("Producto").FontColor("#fff");
                                    header.Cell().Background("#634883").Padding(2).Text("Precio").FontColor("#fff");
                                    header.Cell().Background("#634883").Padding(2).Text("Cantidad").FontColor("#fff");
                                    header.Cell().Background("#634883").Padding(2).Text("Total").FontColor("#fff");
                                });

                                foreach (DetalleVenta item in oVenta.refdetalleVentas)
                                {
                                    decimal cantidad = Convert.ToDecimal(item.cantidad) / Convert.ToDecimal(item.refProducto.refCategoria.refMedida.Valor);
                                    

                                    tabla.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9").Padding(2).
                                    Text(item.refProducto.descripcion).FontSize(10);

                                    tabla.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9").Padding(2).
                                    Text($"{oNegocio.simboloMoneda}{item.precioVenta.ToString("0.00")}").FontSize(10);

                                    tabla.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9").Padding(2).
                                    Text($"{cantidad.ToString()}").FontSize(10);

                                    tabla.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9").Padding(2).
                                    Text($"{oNegocio.simboloMoneda}{item.precioTotal.ToString("0.00")}").FontSize(10);
                                }
                            });
                            column1.Item().AlignRight().Text($"{oNegocio.simboloMoneda}{oVenta.precioTotal.ToString("0.00")}").FontSize(10);
                        });
                        page.Footer().AlignCenter().Text(text => {
                            text.Span("Página").FontSize(10);
                            text.CurrentPageNumber().FontSize(10);
                            text.Span("de").FontSize(10);
                            text.TotalPages().FontSize(10);
                        });
                    });
                });
            }).GeneratePdf();
            return arrayPDF;
        }
    }
}





