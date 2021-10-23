using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GamesSalesStore
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();

           

            var backgroundImageSource = new UriImageSource { Uri = new Uri("https://news.xbox.com/en-us/wp-content/uploads/sites/2/2021/08/HumbleGames_HERO.jpg") };
            backgroundImageSource.CachingEnabled = true;
            backgroundImageSource.CacheValidity = TimeSpan.FromHours(2);
            gamingBackground.Source = backgroundImageSource;

            var gamestoreImageSource = new UriImageSource { Uri = new Uri("https://cdn2.unrealengine.com/Diesel%2Fblog%2Faccount-security-at-epic-games%2FEGS_Social_Update_News-2560x1440-128a69890d92407b815582c1deba54450e5645f9.jpg") };
            gameStoreImage.Source = gamestoreImageSource;
        }

        private async void GameStore_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GamesList());
        }


        
    }
}
