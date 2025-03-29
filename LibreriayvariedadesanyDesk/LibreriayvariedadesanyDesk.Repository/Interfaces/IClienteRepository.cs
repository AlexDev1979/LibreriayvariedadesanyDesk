using LibreriayvariedadesanyDesk.Repository.Entities;

namespace LibreriayvariedadesanyDeskRepository.Interfaces
{
    public interface IClienteRepository
    {
        Task<List<Clientes>> Lista(string buscar = "");

        Task<string> Crear(Clientes objeto);

        Task<string> Editar(Clientes objeto);
    }
}