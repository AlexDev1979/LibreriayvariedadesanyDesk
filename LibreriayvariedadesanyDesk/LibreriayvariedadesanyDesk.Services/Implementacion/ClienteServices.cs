using LibreriayvariedadesanyDesk.Repository.Entities;
using LibreriayvariedadesanyDeskRepository.Interfaces;
using LibreriayvariedadesanyDeskServices.Interfaces;

namespace LibreriayvariedadesanyDeskServices.Implementacion
{
    public class ClienteServices : IClienteServices
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteServices(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task<List<Clientes>> Lista(string buscar = "")
        {
            return await _clienteRepository.Lista(buscar);
        }

        public async Task<string> Crear(Clientes objeto)
        {
            return await _clienteRepository.Crear(objeto);
        }

        public async Task<string> Editar(Clientes objeto)
        {
            return await _clienteRepository.Editar(objeto);
        }
    }
}