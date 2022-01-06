using System;
using System.Collections.Generic;
using System.ComponentModel;
using test1.Models;
using test1.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace test1.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}