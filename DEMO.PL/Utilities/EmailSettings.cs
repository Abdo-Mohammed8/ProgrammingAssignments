using System.Net;
using System.Net.Mail;

namespace DEMO.PL.Utilities
{
    public static class EmailSettings
    {
        public static bool SendEmail(Email email)
        {
            try
            {
                var client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential("abdo.mohammed.pc@gmail.com", "nkht sdfh yego vakb");
                client.Send("abdo.mohammed.pc@gmail.com", email.To, email.Subject, email.Body);
                return true;
            }
            catch (Exception ex) 
            {

                return false;

            }
        
        }
    }
}
