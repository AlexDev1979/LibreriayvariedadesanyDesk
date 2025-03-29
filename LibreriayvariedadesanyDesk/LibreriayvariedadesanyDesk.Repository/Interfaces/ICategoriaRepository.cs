using LibreriayvariedadesanyDesk.Repository.Entities;

namespace LibreriayvariedadesanyDeskRepository.Interfaces
{
    public interface ICategoriaRepository
    {
        Task<List<Categoria>> Lista(string buscar = "");

        Task<string> Crear(Categoria objeto);

        Task<string> Editar(Categoria objeto);
    }
}