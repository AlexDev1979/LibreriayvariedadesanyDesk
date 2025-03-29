using LibreriayvariedadesanyDesk.Repository.Entities;
using LibreriayvariedadesanyDeskRepository.Interfaces;
using LibreriayvariedadesanyDeskServices.Interfaces;

namespace LibreriayvariedadesanyDeskServices.Implementacion
{
    internal class RolServices : IRolservices
    {
        private readonly IRolRepository _rolRepository;

        public RolServices(IRolRepository rolRepository)
        {
            _rolRepository = rolRepository;
        }

        public Task<List<Rol>> Lista()
        {
            return _rolRepository.Lista();
        }
    }
}