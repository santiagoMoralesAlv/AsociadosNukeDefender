using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda
{
    public enum TypeCoins
    {
        A,
        B
    }

    public class BankPlayer
    {
        private float creditsA;
        private float creditsB;


        public float CreditsA
        {
            get
            {
                return creditsA;
            }
        }

        public float CreditsB
        {
            get
            {
                return creditsB;
            }
        }


        public bool CanSendTransfer(float t_credits, TypeCoins type) {
            bool result = false;
            if (type == TypeCoins.A)
            {
                if (creditsA >= t_credits)
                {
                    result = true;
                }
            }
            else
            {
                if (creditsB >= t_credits)
                {
                    result = true;
                }
            }

            return result;
        }

        //envia creditos
        public bool SendTransfer(float t_credits, TypeCoins type) {
            bool result = false;

            if (CanSendTransfer(t_credits, type)) {
                if (type == TypeCoins.A)
                {
                    creditsA -= t_credits;
                    result = true;
                }
                else {
                    creditsB -= t_credits;
                    result = true;
                }
            }
                        
            return result;
        }

        //recibe creditos
        public string ReceiveTransfer(float t_credits, TypeCoins type)
        {

            string result = "";

            if (type == TypeCoins.A)
            {
                creditsA += t_credits;
            }
            else
            {
                creditsB += t_credits;
            }

            result = "Transferencia con exito, nuevo saldo = " +creditsA + "A | B" + creditsB;

            return result;
        }

    }
}
