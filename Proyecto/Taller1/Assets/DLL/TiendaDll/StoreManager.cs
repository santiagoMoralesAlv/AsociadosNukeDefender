using System;
using System.Collections.Generic;

namespace Tienda
{
    class StoreManager
    {
        private Catalogue m_catalogue;
        private float creditsA;
        private float creditsB;

        private static StoreManager instance;

        public static StoreManager Instance
        {
            get
            {
                return instance;
            }
        }

        public StoreManager()
        {
            if (instance == null)
            {
                instance = this;
                m_catalogue = new Catalogue();
            }
        }

        public StoreItem GetItem(string id)
        {
            StoreItem item = m_catalogue.Items.Find(itemList => id == itemList.ItemID);

            return item;
        }


        public bool CanPurchaseItem(String id, BankPlayer bank)
        {
            bool result = false;

            StoreItem item = GetItem(id);

            if (item != null)
            {
                if (bank.CanSendTransfer(item.PriceCoinsA, TypeCoins.A) && bank.CanSendTransfer(item.PriceCoinsB, TypeCoins.B))
                {
                    result = true;
                }
            }

            return result;
        }

        public bool CanPurchaseItem(StoreItem item, BankPlayer bank)
        {
            bool result = false;
          
            if (item != null){
                if (bank.CanSendTransfer( item.PriceCoinsA, TypeCoins.A) && bank.CanSendTransfer(item.PriceCoinsB, TypeCoins.B)) {
                    result = true;
                }
            }

            return result;
        }

        
        public bool BuyItem(String id, BankPlayer bank)
        {
            bool result = false;

            StoreItem item = GetItem(id);

            if ( CanPurchaseItem(item, bank) == true)
            {
                if (bank.SendTransfer(item.PriceCoinsA, TypeCoins.A)) {
                    creditsA += item.PriceCoinsA;
                }
                if (bank.SendTransfer(item.PriceCoinsB, TypeCoins.B))
                {
                    creditsB += item.PriceCoinsB;
                }
                result = true;
            }
            
            return result;
        }


    }
}
