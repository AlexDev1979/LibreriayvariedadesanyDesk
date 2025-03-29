using LibreriayvariedadesanyDesk.Repository.Entities;

namespace LibreriayvariedadesanyDeskRepository.Interfaces
{
    public interface IVentaRepository
    {
        Task<string> Registrar(string ventaXml);

        Task<Venta> Obtener(string numeroVenta);

        Task<List<DetalleVenta>> ObtenerDetalle(string numeroventa);
    }
}