using LibreriayvariedadesanyDeskServices.Implementacion;
using LibreriayvariedadesanyDeskServices.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace LibreriayvariedadesanyDeskServices
{
    public static class DependencyInjection
    {
        public static void RegisterServicesDependendies(this IServiceCollection services)
        {
            services.AddTransient<IMedidaServices, MedidaServices>();
            services.AddTransient<ICategoriaServices, CategoriaServices>();
            services.AddTransient<IProductoServices, ProductoServices>();
            services.AddTransient<INegocioServices, NegocioServices>();
            services.AddTransient<ICloudinaryServices, CloudinaryServices>();
            services.AddTransient<IRolservices, RolServices>();
            services.AddTransient<IUsuarioServices, UsuarioServices>();
            services.AddTransient<ICorreoServices, CorreoServices>();
            services.AddTransient<IVentaServices, VentaServices>();
            services.AddTransient<IMedioPagoServices, MedioPagoServices>();
            services.AddTransient<IClienteServices, ClienteServices>();
            services.AddTransient<IProveedorServices, ProveedorServices>();
        }
    }
}