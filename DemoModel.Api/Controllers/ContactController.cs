using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoModel.Api.Models;
using DemoModel.Api.Models.Client;
using DemoModel.Api.Models.Client.Services;
using DemoModel.Api.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DemoModel.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContactController : ControllerBase
    {
        private IContactRepository<Contact> _service;

        public ContactController()
        {
            _service = new ContactRepository();
        }

        [HttpGet]
        public IEnumerable<Contact> Get()
        {
            return _service.Get();
        }

        [HttpGet("{id}")]
        public Contact Get(int id)
        {
            return _service.Get(id);
        }

        [HttpPost]
        public Contact Post(ContactInfo contactInfo)
        {
            return _service.Insert(new Contact(contactInfo.Nom, contactInfo.Prenom));
        }
    }
}
