using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CardVaiVoa.RuleDomain
{
    public class CreateCard
    {
        public string CreateCards()
        {
            int cardNumber = 0;
            Random randonNumber = new Random();
            int numberBanc = randonNumber.Next(1000, 9999);
            string numberConvert = numberBanc.ToString();
            int bandeiraNumber = 54;
            string bandeiraConvert = bandeiraNumber.ToString();
            int numberUserCard = randonNumber.Next(100000000, 999999999);
            string numberUserCardConvert = numberUserCard.ToString();
            string numberCard = bandeiraConvert + numberConvert + numberUserCardConvert;
            char[] number = numberCard.ToCharArray();
            for (int indice = 0; indice < number.Length; indice++)
            {
                int totalPosicaoPar = 0;
                int totalPositionImpar = 0;

                if (indice % 2 == 0)
                {
                   int numberInt = (int)number[indice];
                    totalPosicaoPar = totalPosicaoPar + (2 * numberInt);
                }
                else 
                { 
                    int numberInt = (int)number[indice];
                    totalPositionImpar = totalPositionImpar + numberInt;
                }
                numberCard = totalPosicaoPar.ToString();

            }
            return numberCard;
        }
    }
}
