using LibreriayvariedadesanyDesk.Repository.Entities;

namespace LibreriayvariedadesanyDeskServices.Interfaces
{
    public interface IClienteServices
    {
        Task<List<Clientes>> Lista(string buscar = "");

        Task<string> Crear(Clientes objeto);

        Task<string> Editar(Clientes objeto);
    }
}