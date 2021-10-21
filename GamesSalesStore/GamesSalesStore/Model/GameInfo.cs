using Newtonsoft.Json;

namespace GamesSalesStore.Model
{
    public partial class GameInfo
    {
        [JsonProperty("internalName")]
        public string InternalName { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("metacriticLink")]
        public string MetacriticLink { get; set; }

        [JsonProperty("dealID")]
        public string DealId { get; set; }

        [JsonProperty("storeID")]
        
        public string StoreId { get; set; }

        [JsonProperty("gameID")]
        
        public string GameId { get; set; }

        [JsonProperty("salePrice")]
        public string SalePrice { get; set; }

        [JsonProperty("normalPrice")]
        public string NormalPrice { get; set; }

        [JsonProperty("isOnSale")]
       
        public string IsOnSale { get; set; }

        [JsonProperty("savings")]
        public string Savings { get; set; }

        [JsonProperty("metacriticScore")]
        
        public string MetacriticScore { get; set; }

        [JsonProperty("steamRatingText")]
        public string SteamRatingText { get; set; }

        [JsonProperty("steamRatingPercent")]
        
        public string SteamRatingPercent { get; set; }

        [JsonProperty("steamRatingCount")]
        
        public string SteamRatingCount { get; set; }

        [JsonProperty("steamAppID")]
        
        public string SteamAppId { get; set; }

        [JsonProperty("releaseDate")]
        public int ReleaseDate { get; set; }

        [JsonProperty("lastChange")]
        public int LastChange { get; set; }

        [JsonProperty("dealRating")]
        public string DealRating { get; set; }

        [JsonProperty("thumb")]
        public string Thumb { get; set; }
    }

}
