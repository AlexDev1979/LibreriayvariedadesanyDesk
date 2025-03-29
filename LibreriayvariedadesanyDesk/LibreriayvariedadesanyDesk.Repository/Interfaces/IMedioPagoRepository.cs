using LibreriayvariedadesanyDesk.Repository.Entities;

namespace LibreriayvariedadesanyDeskRepository.Interfaces
{
    public interface IMedioPagoRepository
    {
        Task<List<MedioPago>> Lista();

        Task<MedioPago> Obtener(string descripcion);
    }
}