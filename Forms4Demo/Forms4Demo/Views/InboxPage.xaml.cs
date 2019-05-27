﻿using Forms4Demo.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Forms4Demo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InboxPage : ContentPage
    {
        public InboxPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();
        }
    }
}