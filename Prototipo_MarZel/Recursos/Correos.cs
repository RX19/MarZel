using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using System.IO;

namespace Prototipo_MarZel.Recursos.Controlador
{
    public static class CorreoHelper
    {
        public static void EnviarCorreo(string mensajeTexto, string destinatario, string rutaAdjunto = null)
        {
            var mensaje = new MimeMessage();
            mensaje.From.Add(new MailboxAddress("MarZel", "roberthunter774@gmail.com"));
            mensaje.To.Add(new MailboxAddress("", destinatario));
            mensaje.Subject = "Notificación desde la aplicación";

            var builder = new BodyBuilder
            {
                TextBody = mensajeTexto
            };

            if (!string.IsNullOrEmpty(rutaAdjunto) && File.Exists(rutaAdjunto))
            {
                builder.Attachments.Add(rutaAdjunto);
            }

            mensaje.Body = builder.ToMessageBody();

            using (var cliente = new SmtpClient())
            {
                cliente.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
                cliente.Authenticate("roberthunter774@gmail.com", "ujrz oyjr xvpw oxmp"); // tu contraseña de app
                cliente.Send(mensaje);
                cliente.Disconnect(true);
            }
        }
    }
}
