using System;
using System.Linq;
using GamesSalesStore.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Net.Http;
using Newtonsoft.Json;
using GamesSalesStore.Model;
using System.Collections.Generic;

namespace GamesSalesStore
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GamesList : ContentPage
    {
        public GamesList()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            games.ItemsSource = await GamesServices.GetGamesList();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            games.ItemsSource = await GamesServices.GetGamesList();
        }

        private void games_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var game = e.Item as GameInfo;
            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
           // DisplayAlert("Tapped", game.Title, "OK");
            DisplayAlert(game.Title, String.Format("Metacritic Score: {0}\nRating: {1}\nSteam ID: {2}\n" +
                "Votes: {3}\nRelease Date: {4}\nLast Update: {5}", game.MetacriticScore, game.SteamRatingText, game.SteamAppId,
                game.SteamRatingCount, dateTime.AddSeconds(game.ReleaseDate), dateTime.AddSeconds(game.LastChange)), "OK");
            
        }

        private async void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            List<GameInfo> gameList = await GamesServices.GetGamesList(e.NewTextValue);
            games.ItemsSource = gameList;
        }

        private async void games_Refreshing(object sender, EventArgs e)
        {
            games.ItemsSource = await GamesServices.GetGamesList();
        }

        private void Buy_Clicked(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var game = (GameInfo)button.BindingContext;
            Navigation.PushAsync(new PurchasePage(game));
        }
    }
}