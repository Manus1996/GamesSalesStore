using GamesSalesStore.Model;
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
    public partial class OrderList : ContentPage
    {
        string _dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "games_sales_store.db");
        public List<Purchase> PurchaseList { get; set; }
        public OrderList()
        {
            InitializeComponent();
        }
        public OrderList(List<Purchase> purchaseList)
        {
            PurchaseList = purchaseList;
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            var db = new SQLiteConnection(_dbPath);
            PurchaseList = db.Table<Purchase>().OrderBy(x => x.IdPurchase).ToList();
            BindingContext = this;
        }
    }
}