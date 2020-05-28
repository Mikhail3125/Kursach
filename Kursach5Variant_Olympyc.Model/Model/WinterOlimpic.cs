using System;
using System.Collections.Generic;

namespace Kursach5Variant_Olympyc.Model.Model
{
    public class WinterOlimpic
    {
        private List<Sporstman> sporstmens;
        public WinterOlimpic()
        {
            sporstmens = new List<Sporstman>();
        }

        public List<Sporstman> Sporstmens { get => sporstmens; }

        public void GetInformationAboutPlacesEveryCountry(string countryName, out int numberOFGold, out int numberOfSilver,
                        out int numberOfBronze,out List<Sporstman> countryWinners)
        {
            numberOFGold = 0;
            numberOfSilver = 0;
            numberOfBronze = 0;
            countryWinners = new List<Sporstman>();
            
            foreach (var item in Sporstmens)
            {
                if (item.Country == countryName)
                {
                    if (item.Place == 1)
                    {
                        numberOFGold += 1;
                        countryWinners.Add(item);
                    }
                    if (item.Place == 2)
                    {
                        numberOfSilver += 1;
                        countryWinners.Add(item);
                    }
                    if (item.Place == 3)
                    {
                        numberOfBronze += 1;
                        countryWinners.Add(item);
                    }
                }
                else
                {
                    throw new ArgumentException("This Country not exist(or not registered on the Olimpic list)");
                }
            }
        }
    }
}
