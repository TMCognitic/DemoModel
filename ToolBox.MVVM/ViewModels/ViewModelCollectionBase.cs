using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ToolBox.MVVM.ViewModels
{
    public abstract class ViewModelCollectionBase<TViewModel> : ViewModelBase
        where TViewModel : ViewModelBase
    {
        private ObservableCollection<TViewModel> _items;

        public ObservableCollection<TViewModel> Items
        {
            get
            {
                return _items ?? (_items = LoadItems());
            }
        }

        public TViewModel SelectedItem
        {
            get
            {
                return _selectedItem;
            }

            set
            {
                if (_selectedItem != value)
                {
                    _selectedItem = value;
                    RaisePropertyChanged();
                }
            }
        }

        private TViewModel _selectedItem;

        protected abstract ObservableCollection<TViewModel> LoadItems();
    }
}
