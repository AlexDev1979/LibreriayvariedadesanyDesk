using LibreriayvariedadesanyDesk.Repository.Entities;

namespace LibreriayvariedadesanyDeskServices.Interfaces
{
    public interface IVentaServices
    {
        Task<string> Registrar(string ventaXml);

        Task<Venta> Obtener(string numeroVenta);

        Task<List<DetalleVenta>> ObtenerDetalle(string numeroVenta);

        Task<List<Venta>> lista(string fechaInicio, string fechaFinal, string buscar = "");

        Task<List<DetalleVenta>> Reporte(string fechaInicio, string fechaFinal);
    }
}