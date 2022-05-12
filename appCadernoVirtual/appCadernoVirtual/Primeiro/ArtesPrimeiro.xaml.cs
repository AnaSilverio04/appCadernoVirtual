using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace appCadernoVirtual.Primeiro
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ArtesPrimeiro : ContentPage
    {
        public ArtesPrimeiro()
        {
            InitializeComponent();
         }
      private void Button_Clicket(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new PrimeiraSerie());
    }

   
    }
}
