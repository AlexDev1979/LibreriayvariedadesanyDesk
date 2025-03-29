using LibreriayvariedadesanyDesk.Repository.Entities;
using LibreriayvariedadesanyDeskRepository.Interfaces;
using LibreriayvariedadesanyDeskServices.Interfaces;

namespace LibreriayvariedadesanyDeskServices.Implementacion
{
    public class NegocioServices : INegocioServices
    {
        private readonly INegocioRepository _negocioRepository;

        public NegocioServices(INegocioRepository negocioRepository)
        {
            _negocioRepository = negocioRepository;
        }

        public async Task<Negocio> Obtener()
        {
            return await _negocioRepository.Obtener();
        }

        public async Task Editar(Negocio objeto)
        {
            await _negocioRepository.Editar(objeto);
        }
    }
}