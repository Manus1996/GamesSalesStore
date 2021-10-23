using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GamesSalesStore
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FAQ : ContentPage
    {
        public FAQ()
        {
            InitializeComponent();

            var faqImageSource = new UriImageSource { Uri = new Uri("https://i.pinimg.com/originals/3c/e6/55/3ce6554630357a7b3821268bc049859d.png") };
            faqImage.Source = faqImageSource;

            //https://i.pinimg.com/originals/3c/e6/55/3ce6554630357a7b3821268bc049859d.png
        }
    }
}