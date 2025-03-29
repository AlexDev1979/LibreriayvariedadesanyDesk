using LibreriayvariedadesanyDesk.Repository.Entities;

namespace LibreriayvariedadesanyDeskServices.Interfaces
{
    public interface INegocioServices
    {
        Task<Negocio> Obtener();

        Task Editar(Negocio objeto);
    }
}