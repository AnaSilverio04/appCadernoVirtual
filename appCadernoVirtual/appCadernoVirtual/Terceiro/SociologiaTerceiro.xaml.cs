﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace appCadernoVirtual.Terceiro
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SociologiaTerceiro : ContentPage
    {
        public SociologiaTerceiro()
        {
            InitializeComponent();
        }
        private void Button_Clicked2(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new TerceiraSerie());
        }

    }
}