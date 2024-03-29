﻿using System;
using Acr.UserDialogs;
using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using FFImageLoading.Forms.Droid;
using SmartHotel.Droid.Services;
using SmartHotel.Services;

namespace SmartHotel.Droid
{
    [Activity(Label = "SmartHotel", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            UserDialogs.Init(this);
            CachedImageRenderer.Init(true);

            global::Xamarin.Forms.Forms.Init(this, bundle);


            ServiceLocator.Instance.Register<IEmailService, EmailServiceDroid>();

            LoadApplication(new App());
        }
    }
}

