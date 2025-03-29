using LibreriayvariedadesanyDesk.Repository.DBConnection;
using LibreriayvariedadesanyDeskRepository.Implementacion;
using LibreriayvariedadesanyDeskRepository.Interfaces;
using Microsoft.Extensions.DependencyInjection;



namespace LibreriayvariedadesanyDeskRepository
{
    public static class DependencyInjection
    {
        public static void RegisterRepositoryDependendies(this IServiceCollection services)
        {
            services.AddSingleton<Connection>();
            services.AddTransient<IMedidaRepository, MedidaRepository>();
            services.AddTransient<ICategoriaRepository, CategoriaRepository>();
            services.AddTransient<IProductoRepository, ProductoRepository>();
            services.AddTransient<INegocioRepository, NegocioRepository>();
            services.AddTransient<IRolRepository, RolRepository>();
            services.AddTransient<IUsuarioRepository, UsuarioRepository>();
            services.AddTransient<IVentaRepository, VentaRepository>();
            services.AddTransient<IMedioPagoRepository, MedioPagoRepository>();
            services.AddTransient<IClienteRepository, ClienteRepository>();
            services.AddTransient<IProveedorRepository, ProveedorRepository>();

        }

    }
}
