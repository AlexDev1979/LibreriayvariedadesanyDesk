using LibreriayvariedadesanyDesk.Repository.Entities;

namespace LibreriayvariedadesanyDeskServices.Interfaces
{
    public interface IVentaServices
    {
        Task<string> Registrar(string ventaXml);

        Task<Venta> Obtener(string numeroVenta);

        Task<List<DetalleVenta>> ObtenerDetalle(string numeroVenta);
    }
}