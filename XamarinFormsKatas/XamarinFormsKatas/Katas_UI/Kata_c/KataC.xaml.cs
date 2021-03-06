﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_c
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KataC : MasterDetailPage
    {
        public KataC()
        {
            InitializeComponent();
            this.Master = new KataCMaster();
            this.Detail = new NavigationPage(new KataCDetail());

            App.MasterC = this;
        }
    }
}