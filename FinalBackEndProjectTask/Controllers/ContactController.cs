using FinalBackEndProjectTask.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalBackEndProjectTask.Controllers
{
    public class ContactController : Controller
    {
        
        
            private HydroDbContext _hydroDbContext;

        public ContactController()
        {
            _hydroDbContext = new HydroDbContext();
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
         [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(ContactMessage contactMessage)
        {
            if (ModelState.IsValid)
           {
                ContactMessage conMess = new ContactMessage
                {
                    Email = contactMessage.Email,
                    Name = contactMessage.Name,
                    Phone = contactMessage.Phone,
                    Budgetlvl = contactMessage.Budgetlvl,
                    text = contactMessage.text,

                };
                _hydroDbContext.ContactMessages.Add(conMess);
            }
            return View();
        }
    }
                

        
    
}