using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamesSalesStore.Model
{
    public class Purchase
    {
        [PrimaryKey]
        public int IdPurchase { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Street { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string GameTitle { get; set; }

    }
}
