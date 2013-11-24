﻿using EPortfolio.Models;
using System.Net;
using System.Net.Mail;
using System.Web.Mvc;

namespace EPortfolio.Controllers
{
    public class ToolsController : Controller
    {
        [HttpPost]
        public void SendMail(MailModel model)
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("addressFrom");
            mail.To.Add("addressTo");
            mail.Subject = "Prise de contact : " + model.Email;
            mail.Body = model.Message;

            SmtpClient SmtpServer = new SmtpClient("smtpClinet");
            SmtpServer.Credentials = new NetworkCredential("address", "mdp");
            SmtpServer.Send(mail);
        }
    }
}