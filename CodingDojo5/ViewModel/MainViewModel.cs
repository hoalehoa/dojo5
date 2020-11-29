using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CodingDojo5.ViewModel
{
    public class MainViewModel:ViewModelBase
    {
        private ItemVM currentItem { get; set; }
        public ObservableCollection<ItemVM> Items { get; set; }
        public ObservableCollection<ItemVM> Cart { get; set; }
        private RelayCommand<ItemVM> buyButton;
       
        public ItemVM CurrentItem
        {
            get { return currentItem; }
            set
            {
                currentItem = value;
                RaisePropertyChanged();
            }
        }
        public RelayCommand<ItemVM> BuyButton
        {
            get
            {
                return buyButton;
            }
            set
            {
                buyButton = value; RaisePropertyChanged();
            }
        }

        public MainViewModel()
        {
            Cart = new ObservableCollection<ItemVM>();
            Items = new ObservableCollection<ItemVM>();
            BuyButton = new RelayCommand<ItemVM>(new Action<ItemVM>(AddtoCart));
        }

        private void AddtoCart(ItemVM obj)
        {
            Cart.Add(obj);
        }
    }
}
