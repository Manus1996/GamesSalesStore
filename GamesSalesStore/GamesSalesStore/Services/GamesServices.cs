using GamesSalesStore.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GamesSalesStore.Services
{
    public class GamesServices
    {
        public static async Task<List<GameInfo>> GetGamesList(string searchText = null)
        {
            var httpClient = new HttpClient();
            var resultJson = await httpClient.GetStringAsync("https://www.cheapshark.com/api/1.0/deals?storeID=1&upperPrice=10&onSale=1&AAA=1");

            var resultGames = JsonConvert.DeserializeObject<GameInfo[]>(resultJson);

            return (String.IsNullOrWhiteSpace(searchText) 
                         ? resultGames
                         : resultGames.Where(c => c.Title.ToLower().Contains(searchText.ToLower()))).ToList();
        }
    }
}
