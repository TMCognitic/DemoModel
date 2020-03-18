using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoModel.Api.Models.Interfaces;
using DemoModel.Models.Client;
using DemoModel.Models.Client.Services;
using DemoModel.Web.Models.Forms;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoModel.Web.Controllers
{
    public class ContactController : Controller
    {
        private IContactRepository<Contact> _service;

        public ContactController()
        {
            _service = new ContactRepository();
        }

        // GET: Contact
        public ActionResult Index()
        {
            return View(_service.Get().Select(c => new DisplayContactModel() { Id = c.Id, Nom = c.Nom, Prenom = c.Prenom }));
        }

        // GET: Contact/Details/5
        public ActionResult Details(int id)
        {
            Contact c = _service.Get(id);
            return View(new DisplayContactModel() { Id = c.Id, Nom = c.Nom, Prenom = c.Prenom });
        }

        // GET: Contact/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Contact/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateContactForm form)
        {
            if(ModelState.IsValid)
            {
                _service.Insert(new Contact(form.Nom, form.Prenom));
                return RedirectToAction("Index");
            }

            return View(form);
        }
    }
}