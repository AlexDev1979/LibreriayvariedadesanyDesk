using LibreriayvariedadesanyDesk.Repository.Entities;
using LibreriayvariedadesanyDeskRepository.Interfaces;
using LibreriayvariedadesanyDeskServices.Interfaces;

namespace LibreriayvariedadesanyDeskServices.Implementacion
{
    public class CategoriaServices : ICategoriaServices
    {
        private readonly ICategoriaRepository _categoriaRepository;

        public CategoriaServices(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        public async Task<List<Categoria>> Lista(string buscar = "")
        {
            return await _categoriaRepository.Lista(buscar);
        }

        public async Task<string> Crear(Categoria objeto)
        {
            return await _categoriaRepository.Crear(objeto);
        }

        public async Task<string> Editar(Categoria objeto)
        {
            return await _categoriaRepository.Editar(objeto);
        }
    }
}