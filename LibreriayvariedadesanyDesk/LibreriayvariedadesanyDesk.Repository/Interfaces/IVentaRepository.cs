using LibreriayvariedadesanyDesk.Repository.Entities;

namespace LibreriayvariedadesanyDeskRepository.Interfaces
{
    public interface IVentaRepository
    {
        Task<string> Registrar(string ventaXml);

        Task<Venta> Obtener(string numeroVenta);

        Task<List<DetalleVenta>> ObtenerDetalle(string numeroventa);

        Task<List<Venta>> lista(string fechaInicio, string fechaFinal, string buscar = "");

        Task<List<DetalleVenta>> Reporte(string fechaInicio, string fechaFinal);

    }
}