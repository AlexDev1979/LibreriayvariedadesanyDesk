using LibreriayvariedadesanyDesk.Repository.Entities;

namespace LibreriayvariedadesanyDeskRepository.Interfaces
{
    public interface IProveedorRepository
    {
        Task<List<Proveedor>> Lista(string buscar = "");

        Task<string> Crear(Proveedor objeto);

        Task<string> Editar(Proveedor objeto);

        Task<Proveedor> ObtenerNombrePorNit(string Nit);
    }
}