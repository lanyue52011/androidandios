﻿// BaseViewModel.cs
// Author:tab <lanyue52011@163.com>
// 4/27/2017 
//
//
namespace androidandios
{
    public class BaseViewModel : ObservableObject
    {
        /// <summary>
        /// Get the azure service instance
        /// </summary>
        public IDataStore<Item> DataStore => ServiceLocator.Instance.Get<IDataStore<Item>>();

        bool isBusy = false;
        public bool IsBusy
        {
            get { return isBusy; }
            set { SetProperty(ref isBusy, value); }
        }

        /// <summary>
        /// Private backing field to hold the title
        /// </summary>
        string title = string.Empty;

        /// <summary>
        /// Public property to set and get the title of the item
        /// </summary>
        public string Title
        {
            get { return title; }
            set { SetProperty(ref title, value); }
        }
    }
}
