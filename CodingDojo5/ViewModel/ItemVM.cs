﻿using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Media.Imaging;

namespace CodingDojo5.ViewModel
{
    public class ItemVM: ViewModelBase
    {
        public String Description { get; set; }
        public BitmapImage Image { get; set; }
        public ObservableCollection<ItemVM> Items{ get; set; }
        public string AgeRecommendation { get; set; }

        public ItemVM(string des, BitmapImage img, string rec)
        {
            Description = des;
            Image = img;
            AgeRecommendation = rec;
        }
        public void AddItem(ItemVM item)
        {
            if(Items == null)
            {
                Items = new ObservableCollection<ItemVM>();
            }
            Items.Add(item);
        }

    }
}
