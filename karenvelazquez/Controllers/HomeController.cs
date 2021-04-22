using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Net;
using System.Net.Mail;


namespace karenvelazquez.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult Contact()
        {

            ViewBag.Message = "Your contact page.";

            return View();

        }
        [HttpPost]

        public ActionResult EnviarCorreo(String para, String asunto, String mensaje)
        {
            

            try
            {

                MailMessage correo = new MailMessage();
                correo.From = new MailAddress("kcindyvelazquez@gmail.com");
                correo.To.Add(para);
                correo.Subject = asunto;
                correo.Body = mensaje;
                correo.IsBodyHtml = true;
                correo.Priority = MailPriority.Normal;

                //Se almacena los archivos adjuntados de una carpeta creada en el proyecto

                //String ruta = Server.MapPath("..Temporal");
                //fichero.SaveAs(ruta + "\\" + fichero.FileName);

                //Attachment adjunto = new Attachment(ruta + "\\" + fichero.FileName);
                //correo.Attachments.Add(adjunto);

                //Configuracion del servidor SMTP

                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 25;
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = true;
                string sCuentaCorreo = "sabrinasaledad95@gmail.com";
                string sPasswordCorreo = "123456789Mjm";

                smtp.Credentials = new System.Net.NetworkCredential(sCuentaCorreo, sPasswordCorreo);

                smtp.Send(correo);
                ViewBag.Mensaje = "Mensaje enviado correctamente";
                //System.IO.File.Delete(ruta + "\\" + fichero.FileName);


            }
            catch (Exception ex)
            {

                ViewBag.Error = ex.Message;
            }
            return View();
        }


    }
}