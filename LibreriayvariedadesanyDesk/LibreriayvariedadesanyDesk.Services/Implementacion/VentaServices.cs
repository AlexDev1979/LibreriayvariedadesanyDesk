using LibreriayvariedadesanyDesk.Repository.Entities;
using LibreriayvariedadesanyDeskRepository.Interfaces;
using LibreriayvariedadesanyDeskServices.Interfaces;

namespace LibreriayvariedadesanyDeskServices.Implementacion
{
    public class VentaServices : IVentaServices
    {
        private readonly IVentaRepository _ventaRepository;

        public VentaServices(IVentaRepository ventaRepository)
        {
            _ventaRepository = ventaRepository;
        }

        public async Task<string> Registrar(string ventaXml)
        {
            return await _ventaRepository.Registrar(ventaXml);
        }

        public async Task<Venta> Obtener(string numeroVenta)
        {
            return await _ventaRepository.Obtener(numeroVenta);
        }

        public async Task<List<DetalleVenta>> ObtenerDetalle(string numeroventa)
        {
            return await _ventaRepository.ObtenerDetalle(numeroventa);
        }

        public async Task<List<Venta>> lista(string fechaInicio, string fechaFinal, string buscar = "")
        {
            return await _ventaRepository.lista(fechaInicio, fechaFinal, buscar);
        }

        public async Task<List<DetalleVenta>> Reporte(string fechaInicio, string fechaFinal)
        {
            return await _ventaRepository.Reporte(fechaInicio, fechaFinal);
        }
    }
}