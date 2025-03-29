using LibreriayvariedadesanyDesk.Repository.Entities;
using LibreriayvariedadesanyDeskRepository.Interfaces;
using LibreriayvariedadesanyDeskServices.Interfaces;

namespace LibreriayvariedadesanyDeskServices.Implementacion
{
    internal class MedioPagoServices : IMedioPagoServices
    {
        private readonly IMedioPagoRepository _medioPagoRepository;

        public MedioPagoServices(IMedioPagoRepository medioPagoRepository)
        {
            _medioPagoRepository = medioPagoRepository;
        }

        public async Task<List<MedioPago>> Lista()
        {
            return await _medioPagoRepository.Lista();
        }

        public async Task<MedioPago> Obtener(string descripcion)
        {
            return await _medioPagoRepository.Obtener(descripcion);
        }
    }
}