using LibreriayvariedadesanyDesk.Repository.Entities;
using LibreriayvariedadesanyDeskRepository.Interfaces;
using LibreriayvariedadesanyDeskServices.Interfaces;

namespace LibreriayvariedadesanyDeskServices.Implementacion
{
    public class ProductoServices : IProductoServices
    {
        private readonly IProductoRepository _ProductoRepository;

        public ProductoServices(IProductoRepository ProductoRepository)
        {
            _ProductoRepository = ProductoRepository;
        }

        public async Task<List<Producto>> Lista(string buscar = "")
        {
            return await _ProductoRepository.Lista(buscar);
        }

        public async Task<string> Crear(Producto objeto)
        {
            return await _ProductoRepository.Crear(objeto);
        }

        public async Task<string> Editar(Producto objeto)
        {
            return await _ProductoRepository.Editar(objeto);
        }

        public async Task<Producto> Obtener(string codigo)
        {
            return await _ProductoRepository.Obtener(codigo);
        }

        public async Task<Producto> ActualizarPrecioVenta(int codigoProducto, decimal nuevoPrecio)
        {
            return await _ProductoRepository.ActualizarPrecioVenta(codigoProducto, nuevoPrecio);
        }
    }
}