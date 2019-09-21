using System;
using System.Collections.Generic;

namespace Tienda
{
    

    class StoreItem
    {

        private string itemID;
        private string itemName;
        private float priceCoinsA;
        private float priceCoinsB;

        public string ItemID
        {
            get
            {
                return itemID;
            }
        }
        public string ItemName
        {
            get
            {
                return itemName;
            }
        }
        public float PriceCoinsA
        {
            get
            {
                return priceCoinsA;
            }
        }
        public float PriceCoinsB
        {
            get
            {
                return priceCoinsB;
            }
        }
                
        public StoreItem(string t_itemID, string t_itemName, float t_price, TypeCoins t_type)
        {
            itemID = t_itemID;
            itemName = t_itemName;

            if (t_type == TypeCoins.A)
                priceCoinsA=t_price;
            else
                priceCoinsB=t_price;
        }

        public StoreItem(string t_itemID, string t_itemName, float t_priceA, float t_priceB)
        {
            itemID = t_itemID;
            itemName = t_itemName;
            priceCoinsA = t_priceA;
            priceCoinsB = t_priceB;
        }
    }
}
