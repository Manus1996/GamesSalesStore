using GamesSalesStore.Model;
using GamesSalesStore.Services;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GamesSalesStore
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PurchasePage : ContentPage
    {
        string _dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "games_sales_store.db");
        private GameInfo _game;
        private List<string> _titles;

        public PurchasePage(GameInfo game)
        {
            _game = game;
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            var data = await GamesServices.GetGamesList();
            _titles = data.Select(c => c.Title).ToList();
            pickerGame.ItemsSource = _titles;

            if(_game != null)
            {
                pickerGame.SelectedItem = _game.Title;
            }
        }

        public PurchasePage() => InitializeComponent();

        private async void AddOrder_Clicked(object sender, EventArgs e)
        {
            var db = new SQLiteConnection(_dbPath);
            db.CreateTable<Purchase>();

            var maxPk = db.Table<Purchase>().OrderByDescending(c => c.IdPurchase).FirstOrDefault();

            Purchase purchase = new Purchase()
            {
                IdPurchase = (maxPk == null ? 1 : maxPk.IdPurchase + 1),
                FirstName = entryFirstName.Text,
                LastName = entryLastName.Text,
                Street = entryStreet.Text,
                State = entryState.Text,
                Country = entryCountry.Text,
                GameTitle = pickerGame.SelectedItem.ToString()
            };
            db.Insert(purchase);
            await DisplayAlert(null, "Comanda cu ID-ul: " + purchase.IdPurchase + " a fost adaugata", "Ok");
            await Navigation.PopAsync();
        }
    }
}