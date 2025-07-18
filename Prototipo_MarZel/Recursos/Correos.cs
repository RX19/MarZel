using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;

namespace Prototipo_MarZel.Recursos.Controlador
{
    public static class CorreoHelper
    {
        public static void EnviarCorreo(string mensajeTexto, string destinatario)
        {
            var mensaje = new MimeMessage();
            mensaje.From.Add(new MailboxAddress("MarZel", "roberthunter774@gmail.com")); // Remitente
            mensaje.To.Add(new MailboxAddress("", destinatario)); // Destinatario
            mensaje.Subject = "Notificación desde la aplicación";

            mensaje.Body = new TextPart("plain")
            {
                Text = mensajeTexto
            };

            using (var cliente = new SmtpClient())
            {
                cliente.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
                cliente.Authenticate("roberthunter774@gmail.com", "ujrz oyjr xvpw oxmp"); //contraseña de app
                cliente.Send(mensaje);
                cliente.Disconnect(true);
            }
        }
    }
}
