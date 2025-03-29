using LibreriayvariedadesanyDesk.Repository.Entities;

namespace LibreriayvariedadesanyDeskRepository.Interfaces
{
    public interface IUsuarioRepository
    {
        Task<List<Usuario>> Lista(string buscar = "");

        Task<string> Crear(Usuario objeto);

        Task<string> Editar(Usuario objeto);
    }
}