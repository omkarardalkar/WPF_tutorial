using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using V06_MVVM_test.Model;
using V06_MVVM_test.MVVM;

namespace V06_MVVM_test.ViewModel
{
    internal class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<Item> Items { get; set; }

        public RelayCommand AddCommand => new RelayCommand(execute => AddItem(), canExecute => { return true; });
        public RelayCommand DeleteCommand => new RelayCommand(execute => DeleteItem(), canExecute => SelectedItem!=null);
        public RelayCommand ClearAllCommand => new RelayCommand(execute => ClearAll(), canExecute => { return true; });
        public MainWindowViewModel() 
        {
            Items = new ObservableCollection<Item>();
            //Items.Add(new Item { Name = "Item 1", SerialNumber = "00001", Quantity = "5" });
            //Items.Add(new Item { Name = "Item 2", SerialNumber = "00002", Quantity = "10" });
            //Items.Add(new Item { Name = "Item 3", SerialNumber = "00003", Quantity = "16" });
            //Items.Add(new Item { Name = "Item 4", SerialNumber = "00004", Quantity = "11" });
            //Items.Add(new Item { Name = "Item 5", SerialNumber = "00005", Quantity = "25" });


        }
        private Item selectItem;
        public Item SelectedItem
        {
            get { return selectItem; }
            set 
            { 
                selectItem = value;
                OnPropertyChanged();
            }
        }
        private void AddItem()
        {
            Items.Add(new Item { Name = "Item 99", SerialNumber = "000099", Quantity = "5" });
        }
        private void DeleteItem()
        {
            Items.Remove(SelectedItem);
        }
        private void ClearAll()
        {
            Items.Clear();
        }
    }
}
