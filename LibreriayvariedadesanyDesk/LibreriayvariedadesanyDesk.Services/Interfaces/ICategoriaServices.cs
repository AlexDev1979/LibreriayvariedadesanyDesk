using LibreriayvariedadesanyDesk.Repository.Entities;

namespace LibreriayvariedadesanyDeskServices.Interfaces
{
    public interface ICategoriaServices
    {
        Task<List<Categoria>> Lista(string buscar = "");

        Task<string> Crear(Categoria objeto);

        Task<string> Editar(Categoria objeto);
    }
}