using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using LibreriayvariedadesanyDesk.Recursos.Cloudinary;
using LibreriayvariedadesanyDeskServices.Interfaces;
using Microsoft.Extensions.Configuration;

namespace LibreriayvariedadesanyDeskServices.Implementacion
{
    public class CloudinaryServices : ICloudinaryServices
    {
        private readonly IConfiguration _configuration;
        private readonly Cloudinary _cloudinary;

        public CloudinaryServices(IConfiguration configuration)
        {
            _configuration = configuration;

            var CloudName = _configuration["Cloudinary:CloudName"];
            var ApiKey = _configuration["Cloudinary:ApiKey"];
            var ApiSecret = _configuration["Cloudinary:ApiSecret"];

            _cloudinary = new Cloudinary(new Account(CloudName, ApiKey, ApiSecret));
        }

        public async Task<CloudinaryResponse> SubirImagen(string nombreImagen, Stream formatoImagen)
        {
            var clouddinaryresponse = new CloudinaryResponse();

            var uploadParams = new ImageUploadParams()
            {
                File = new FileDescription(nombreImagen, formatoImagen),
                AssetFolder = "SistemaVentasWF"
            };

            var uploadResult = await _cloudinary.UploadAsync(uploadParams);

            if (uploadResult.StatusCode == System.Net.HttpStatusCode.OK)
            {
                clouddinaryresponse.PublicId = uploadResult.PublicId;
                clouddinaryresponse.SecureUrl = uploadResult.SecureUrl.ToString();
            }
            else
            {
                clouddinaryresponse.PublicId = "";
            }
            return clouddinaryresponse;
        }

        public async Task<bool> EliminarImagen(string publicid)
        {
            var deleteParams = new DeletionParams(publicid);
            var deleteResult = await _cloudinary.DestroyAsync(deleteParams);

            if (deleteResult.StatusCode == System.Net.HttpStatusCode.OK)
                return true;
            else
                return false;
        }
    }
}