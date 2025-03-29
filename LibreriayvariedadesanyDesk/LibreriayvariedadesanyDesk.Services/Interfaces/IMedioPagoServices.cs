using LibreriayvariedadesanyDesk.Repository.Entities;

namespace LibreriayvariedadesanyDeskServices.Interfaces
{
    public interface IMedioPagoServices
    {
        Task<List<MedioPago>> Lista();

        Task<MedioPago> Obtener(string descripcion);
    }
}