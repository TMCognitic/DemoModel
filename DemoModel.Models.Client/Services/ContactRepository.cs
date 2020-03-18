using DemoModel.Api.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

using S = DemoModel.Models.Global.Services;
using G = DemoModel.Models.Global;
using System.Linq;
using DemoModel.Models.Client.Mappers;

namespace DemoModel.Models.Client.Services
{
    public class ContactRepository : IContactRepository<Contact>
    {
        private IContactRepository<G.Contact> _globalService;

        public ContactRepository()
        {
            _globalService = new S.ContactRepository();
        }

        public IEnumerable<Contact> Get()
        {
            return _globalService.Get().Select(c => c.ToClient());
        }

        public Contact Get(int id)
        {
            return _globalService.Get(id)?.ToClient();
        }

        public Contact Insert(Contact entity)
        {
            return _globalService.Insert(entity.ToGlobal()).ToClient();
        }
    }
}
