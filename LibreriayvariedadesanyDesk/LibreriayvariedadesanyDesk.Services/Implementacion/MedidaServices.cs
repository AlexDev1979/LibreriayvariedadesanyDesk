using LibreriayvariedadesanyDesk.Repository.Entities;
using LibreriayvariedadesanyDeskRepository.Interfaces;
using LibreriayvariedadesanyDeskServices.Interfaces;

namespace LibreriayvariedadesanyDeskServices.Implementacion
{
    public class MedidaServices : IMedidaServices
    {
        private readonly IMedidaRepository _medidaRepository;

        public MedidaServices(IMedidaRepository medidaRepository)
        {
            _medidaRepository = medidaRepository;
        }

        public async Task<List<Medida>> Lista()
        {
            return await _medidaRepository.Lista();
        }
    }
}