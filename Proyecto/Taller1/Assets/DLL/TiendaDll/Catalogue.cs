using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda
{
    class Catalogue
    {

        private List<StoreItem> items = new List<StoreItem>();

        public List<StoreItem> Items
        {
            get
            {
                return items;
            }
        }

        public Catalogue() {

            items.Add(new StoreItem("H001", "Barrido", 1, TypeCoins.A));
            items.Add(new StoreItem("H002", "Berserk", 1, TypeCoins.A));
            items.Add(new StoreItem("H003", "Barrera", 1, TypeCoins.A));

            items.Add(new StoreItem("M001", "Daño", 1, TypeCoins.B));
            items.Add(new StoreItem("M002", "AOE", 1, TypeCoins.B));
            items.Add(new StoreItem("M003", "Velocidad", 1, TypeCoins.B));


            items.Add(new StoreItem("Ov001", "Overkill", 1, 1));
        }

        
    }
}
