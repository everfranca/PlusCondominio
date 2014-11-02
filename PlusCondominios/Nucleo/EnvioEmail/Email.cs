using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnvioEmail
{
    public class Email
    {
        public Email()
        {

        }
        public bool EnviarEmail(string endereco, string titulo, string corpo_email)
        {
            bool sucesso;

            try
            {
                System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();
                //enviando parar
                message.To.Add(endereco);
                //titulo Mensagem
                message.Subject = titulo;
               // message.Subject = "Serviço de Recuperação de senha Manager5.0";
                //enviador por 
                message.From = new System.Net.Mail.MailAddress("naoresponda@sebsa.com.br");
                //copor da mensagem 
                message.IsBodyHtml = true;

                message.Body = corpo_email;
                //message.Body += "<b>Recuperação de Senha Manager5.0</b><br>";
                //message.Body += "Olá <strong>" + usu_nome + "</strong>,para solicitar uma nova senha por favor acesse o link abaixo.";
                //message.Body += "<br><a href=" + link + ">" + link + "</a>";

                //servidor de saida smtp
                System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("mail3.sebsa.com.br");
                //enviar mensagem 
                smtp.Send(message);

                sucesso = true;
            }
            catch (Exception exc)
            {
                sucesso = false;
            }
            return sucesso;
        }

        public bool EnviarEmailComAnexo(string endereco, string titulo, string corpo_email , string caminho_anexo)
        {
            System.Net.Mail.MailMessage mensagem = new System.Net.Mail.MailMessage();
            System.Net.Mail.Attachment anexo = new System.Net.Mail.Attachment(caminho_anexo);
            System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("mail3.sebsa.com.br");

            bool sucesso;

            try
            {
                //enviada por
                mensagem.From = new System.Net.Mail.MailAddress("naoresponda@sebsa.com.br");
                // enviar para 
                mensagem.To.Add(endereco);
                //titulo mensagem
                mensagem.Subject = titulo;
                // anexo mensagem
                if(caminho_anexo != null)
                mensagem.Attachments.Add(anexo);
                // corpo mensagem 
                mensagem.IsBodyHtml = true;
                mensagem.Body = corpo_email;
                //servidor de saída
                smtp.Send(mensagem);
                sucesso = true;
            }
            catch (Exception)
            {
                sucesso = false;
            }
            finally
            {
                mensagem = null;
                smtp = null;
            }
            return sucesso;
        }
    }
}
