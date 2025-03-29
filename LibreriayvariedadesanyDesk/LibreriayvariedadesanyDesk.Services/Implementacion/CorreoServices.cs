using LibreriayvariedadesanyDeskServices.Interfaces;
using MailKit.Net.Smtp;
using Microsoft.Extensions.Configuration;
using MimeKit;

namespace LibreriayvariedadesanyDeskServices.Implementacion
{
    public class CorreoServices : ICorreoServices
    {
        private readonly IConfiguration _configuration;
        private SmtpClient _smtpClient;
        private readonly string _host;
        private readonly int _port;
        private readonly string _user;
        private readonly string _pass;

        public CorreoServices(IConfiguration configuration)
        {
            _configuration = configuration;
            _smtpClient = new SmtpClient();
            _host = _configuration["Smtp:host"]!;
            _port = Convert.ToInt32(_configuration["Smtp:port"]!);
            _user = _configuration["Smtp:user"]!;
            _pass = _configuration["Smtp:pass"]!;
        }

        public async Task Enviar(string para, string asunto, string mensajeHtml)
        {
            _smtpClient = new SmtpClient();
            _smtpClient.Connect(_host, _port, MailKit.Security.SecureSocketOptions.StartTls);
            _smtpClient.Authenticate(_user, _pass);

            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse(_user));
            email.To.Add(MailboxAddress.Parse(para));
            email.Subject = asunto;
            email.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = mensajeHtml
            };
            await _smtpClient.SendAsync(email);
            await _smtpClient.DisconnectAsync(true);
        }
    }
}