using NoteBooks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Net.Mail;
using System.Net;

namespace NoteBooks.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SendMessage(Message message)
        {
            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("dmi.workbox@gmail.com", "28mijczc"),
                EnableSsl = true
            };
            client.Send("dmi.workbox@gmail.com", "mechenite@gmail.com", "Свяжитесь со мной", $"Имя: {message.Name}{Environment.NewLine}Контактная информация: {message.ContactData}{Environment.NewLine}Сообщение: {message.Text}");
            return Json(new {msg="fff" });
        }
    }


}