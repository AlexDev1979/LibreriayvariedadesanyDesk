using LibreriayvariedadesanyDesk.Repository.Entities;

namespace LibreriayvariedadesanyDeskServices.Interfaces
{
    public interface IProductoServices
    {
        Task<List<Producto>> Lista(string buscar = "");

        Task<string> Crear(Producto objeto);

        Task<string> Editar(Producto objeto);

        Task<Producto> Obtener(string codigo);

        Task<Producto> ActualizarPrecioVenta(int codigoProducto, decimal nuevoPrecio);
    }
}