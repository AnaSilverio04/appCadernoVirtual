using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace appCadernoVirtual.Segundo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GeografiaSegundo : ContentPage
    {
        public GeografiaSegundo()
        {
            InitializeComponent();
        }
        private void Button_Clicked1(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new SegundaSerie());
        }

    }
}