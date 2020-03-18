using DemoModel.Models.Client;
using System;
using System.Collections.Generic;
using System.Text;
using ToolBox.MVVM.ViewModels;

namespace DemoModel.ViewModels
{
    public class ContactViewModel : ViewModelBase<Contact>
    {
        public ContactViewModel(Contact entity) : base(entity)
        {
        }

        public int Id
        {
            get { return Entity.Id; }
        }

        public string Nom
        {
            get { return Entity.Nom; }
        }

        public string Prenom
        {
            get { return Entity.Prenom; }
        }
    }
}
