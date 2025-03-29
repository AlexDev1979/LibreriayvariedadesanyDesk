using LibreriayvariedadesanyDesk.Recursos.Cloudinary;

namespace LibreriayvariedadesanyDeskServices.Interfaces
{
    public interface ICloudinaryServices
    {
        Task<CloudinaryResponse> SubirImagen(string nombreImagen, Stream formatoImagen);

        Task<bool> EliminarImagen(string publicid);
    }
}