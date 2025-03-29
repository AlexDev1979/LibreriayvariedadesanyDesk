namespace LibreriayvariedadesanyDeskServices.Interfaces
{
    public interface ICorreoServices
    {
        Task Enviar(string para, string asunto, string mensajeHtml);
    }
}