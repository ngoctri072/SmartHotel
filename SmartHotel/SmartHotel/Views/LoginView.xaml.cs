﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartHotel.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartHotel.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginView : ContentPage
	{
        public LoginView ()
		{
			InitializeComponent ();

		    NavigationPage.SetHasNavigationBar(this, false);
		}        
    }
}