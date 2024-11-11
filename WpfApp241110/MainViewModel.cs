
﻿using System.Collections.ObjectModel;
using System.ComponentModel;

namespace WpfApp241111
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<string> _items;
        public ObservableCollection<string> Items
        {
            get { return _items; }
            set
            {
                if (_items != value)
                {
                    _items = value;
                    OnPropertyChanged(nameof(Items));
                }
            }
        }

        public MainViewModel ()
        {
            Items = new ObservableCollection<string> { "Item 1", "Item 2", "Item 3" };
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged (string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void AddItem (string newItem)
        {
            Items.Add(newItem);
        }

        public void RemoveItem (string item)
        {
            if (Items.Contains(item))
                Items.Remove(item);
        }
    }
}
