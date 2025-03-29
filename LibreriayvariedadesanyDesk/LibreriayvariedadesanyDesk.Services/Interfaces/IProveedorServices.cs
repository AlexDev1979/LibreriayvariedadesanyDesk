using LibreriayvariedadesanyDesk.Repository.Entities;

namespace LibreriayvariedadesanyDeskServices.Interfaces
{
    public interface IProveedorServices
    {
        Task<List<Proveedor>> Lista(string buscar = "");

        Task<string> Crear(Proveedor objeto);

        Task<string> Editar(Proveedor objeto);

        Task<Proveedor> ObtenerNombrePorNit(string Nit);
    }
}