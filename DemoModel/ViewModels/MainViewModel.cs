using DemoModel.Api.Models.Interfaces;
using DemoModel.Models.Client;
using DemoModel.Models.Client.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using ToolBox.MVVM.ViewModels;

namespace DemoModel.ViewModels
{
    public class MainViewModel : ViewModelCollectionBase<ContactViewModel>
    {
        private IContactRepository<Contact> _service;

        public MainViewModel()
        {
            _service = new ContactRepository();
        }

        protected override ObservableCollection<ContactViewModel> LoadItems()
        {
            return new ObservableCollection<ContactViewModel>(_service.Get().Select(c => new ContactViewModel(c)));
        }
    }
}
