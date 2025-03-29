using LibreriayvariedadesanyDesk.Repository.Entities;

namespace LibreriayvariedadesanyDeskServices.Interfaces
{
    public interface IUsuarioServices
    {
        Task<List<Usuario>> Lista(string buscar = "");

        Task<string> Crear(Usuario objeto);

        Task<string> Editar(Usuario objeto);
    }
}