using LibreriayvariedadesanyDesk.Repository.Entities;

namespace LibreriayvariedadesanyDeskRepository.Interfaces
{
    public interface INegocioRepository
    {
        Task<Negocio> Obtener();

        Task Editar(Negocio objeto);
    }
}