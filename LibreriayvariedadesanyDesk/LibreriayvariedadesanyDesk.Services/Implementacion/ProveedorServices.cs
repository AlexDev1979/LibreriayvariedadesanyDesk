using LibreriayvariedadesanyDesk.Repository.Entities;
using LibreriayvariedadesanyDeskRepository.Interfaces;
using LibreriayvariedadesanyDeskServices.Interfaces;

namespace LibreriayvariedadesanyDeskServices.Implementacion
{
    public class ProveedorServices : IProveedorServices
    {
        private readonly IProveedorRepository _proveedorRepository;

        public ProveedorServices(IProveedorRepository proveedorRepository)
        {
            _proveedorRepository = proveedorRepository;
        }

        public async Task<List<Proveedor>> Lista(string buscar = "")
        {
            return await _proveedorRepository.Lista(buscar);
        }

        public async Task<string> Crear(Proveedor objeto)
        {
            return await _proveedorRepository.Crear(objeto);
        }

        public async Task<string> Editar(Proveedor objeto)
        {
            return await _proveedorRepository.Editar(objeto);
        }

        public async Task<Proveedor> ObtenerNombrePorNit(string Nit)
        {
            return await _proveedorRepository.ObtenerNombrePorNit(Nit);
        }
    }
}