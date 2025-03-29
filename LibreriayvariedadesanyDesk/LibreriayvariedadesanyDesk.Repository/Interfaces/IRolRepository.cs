using LibreriayvariedadesanyDesk.Repository.Entities;

namespace LibreriayvariedadesanyDeskRepository.Interfaces
{
    public interface IRolRepository
    {
        Task<List<Rol>> Lista();
    }
}