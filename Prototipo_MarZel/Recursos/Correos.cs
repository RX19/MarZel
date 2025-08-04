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
            mensaje.From.Add(new MailboxAddress("MarZel", "internetmarzel@gmail.com"));
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
                cliente.Authenticate("internetmarzel@gmail.com", "hbot ulct uaxm zkld"); // tu contraseña de app
                cliente.Send(mensaje);
                cliente.Disconnect(true);
            }
        }

        public static void EnviarCorreoFactura(string destinatario, string numeroFactura, string rutaAdjunto, DateTime fecha)
        {
            var mensaje = new MimeMessage();
            mensaje.From.Add(new MailboxAddress("MarZel", "internetmarzel@gmail.com"));
            mensaje.To.Add(new MailboxAddress("", destinatario));
            mensaje.Subject = $"Factura #{numeroFactura} - MarZel";

            var builder = new BodyBuilder
            {
                TextBody = $@"
                            Estimado cliente,

                            Gracias por su compra con MarZel. Adjunto encontrará la factura correspondiente a su compra número #{numeroFactura}, realizada el {fecha:dd/MM/yyyy}.

                            Le agradecemos por confiar en nosotros. Si tiene alguna duda o necesita asistencia adicional, no dude en contactarnos.

                            Atentamente,
                            El equipo de MarZel."
            };

            if (!string.IsNullOrEmpty(rutaAdjunto) && File.Exists(rutaAdjunto))
            {
                builder.Attachments.Add(rutaAdjunto);
            }

            mensaje.Body = builder.ToMessageBody();

            using (var cliente = new SmtpClient())
            {
                cliente.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
                cliente.Authenticate("internetmarzel@gmail.com", "hbot ulct uaxm zkld"); // tu contraseña de app
                cliente.Send(mensaje);
                cliente.Disconnect(true);
            }
        }


    }
}
