using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace Lab04
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarouselPage2 : CarouselPage
    {
        public CarouselPage2()
        {
            InitializeComponent();
            btnClose.Clicked += async (sender, e) =>
            {
                await Navigation.PopAsync();
            };
        }
    }
}