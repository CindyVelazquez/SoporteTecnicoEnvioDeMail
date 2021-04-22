//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Net.Mail;
//using System.Web.Mvc;

//namespace karenvelazquez.Controllers
//{
//    public class EnviarCorreoController : Controller
//    {
//        // GET: EnviarCorrep
//        public ActionResult Index()
//        {
//            return View();
//        }
//        //prctica de correo
//        [HttpGet]

//        public ActionResult EnviarCorreo()
//        {
//            return View();

//        }

//        [HttpPost]

//        public ActionResult EnviarCorreo(String para, String asunto, String mensaje, HttpPostedFileBase fichero)
//        {

//            try
//            {

//                MailMessage correo = new MailMessage();
//                correo.From = new MailAddress("sabrinasaledad95@gmail.com");
//                correo.To.Add(para);
//                correo.Subject = asunto;
//                correo.Body = mensaje;
//                correo.IsBodyHtml = true;
//                correo.Priority = MailPriority.Normal;

//                //Se almacena los archivos adjuntados de una carpeta creada en el proyecto

//                //String ruta = Server.MapPath("..Temporal");
//                //fichero.SaveAs(ruta + "\\" + fichero.FileName);

//                //Attachment adjunto = new Attachment(ruta + "\\" + fichero.FileName);
//                //correo.Attachments.Add(adjunto);

//                //Configuracion del servidor SMTP

//                SmtpClient smtp = new SmtpClient();
//                smtp.Host = "smtp.gmail.com";
//                smtp.Port = 25;
//                smtp.EnableSsl = true;
//                smtp.UseDefaultCredentials = true;
//                string sCuentaCorreo = "sabrinasaledad95@gmail.com";
//                string sPasswordCorreo = "123456789Mjm";

//                smtp.Credentials = new System.Net.NetworkCredential(sCuentaCorreo, sPasswordCorreo);

//                smtp.Send(correo);
//                ViewBag.Mensaje = "Mensaje enviado correctamente";
//                //System.IO.File.Delete(ruta + "\\" + fichero.FileName);


//            }
//            catch (Exception ex)
//            {

//                ViewBag.Error = ex.Message;
//            }
//            return View();
//        }
//    }
//}

        
////        // GET: EnviarCorrep/Details/5
////        public ActionResult Details(int id)
////        {
////            return View();
////        }

////        // GET: EnviarCorrep/Create
////        public ActionResult Create()
////        {
////            return View();
////        }

////        // POST: EnviarCorrep/Create
////        [HttpPost]
////        public ActionResult Create(FormCollection collection)
////        {
////            try
////            {
////                // TODO: Add insert logic here

////                return RedirectToAction("Index");
////            }
////            catch
////            {
////                return View();
////            }
////        }

////        // GET: EnviarCorrep/Edit/5
////        public ActionResult Edit(int id)
////        {
////            return View();
////        }

////        // POST: EnviarCorrep/Edit/5
////        [HttpPost]
////        public ActionResult Edit(int id, FormCollection collection)
////        {
////            try
////            {
////                // TODO: Add update logic here

////                return RedirectToAction("Index");
////            }
////            catch
////            {
////                return View();
////            }
////        }

////        // GET: EnviarCorrep/Delete/5
////        public ActionResult Delete(int id)
////        {
////            return View();
////        }

////        // POST: EnviarCorrep/Delete/5
////        [HttpPost]
////        public ActionResult Delete(int id, FormCollection collection)
////        {
////            try
////            {
////                // TODO: Add delete logic here

////                return RedirectToAction("Index");
////            }
////            catch
////            {
////                return View();
////            }
////        }
////    }
////}
