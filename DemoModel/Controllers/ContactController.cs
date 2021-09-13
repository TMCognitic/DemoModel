using BLL.Entities;
using BLL.Repositories;
using DemoModel.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoModel.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactRepository _repository;

        public ContactController(IContactRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index(string filter)
        {
            IEnumerable<Contact> contacts = (filter is null) ? _repository.Get() : _repository.Get(c => c.FullName.ToLower().Contains(filter.ToLower()));
            return View(contacts.ToList().Select(c => new DisplayContact() { Id = c.Id, FullName = c.FullName }));            
        }
    }
}
