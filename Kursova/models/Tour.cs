using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova.models
{
   public class Tour
    {
        public String nameTour;
        public String typeTour; 
        public String transport;
        public int durationDay;
        public List<Locality> localities;
        public List<PriceList> priceLists;



        public Tour(String name, String type, String transport, int durationDay, Locality locality)
        {
            this.nameTour = name;
            this.typeTour = type;
            this.transport = transport;
            this.durationDay = durationDay;
            localities = new List<Locality>();
            priceLists = new List<PriceList>();
            localities.Add(locality);
        }



        public bool AddLocality(Locality locality)
        {
            if (!ContainsLocality(locality))
            {
                localities.Add(locality);
                return true;
            }
            else return false;

        }



        public bool ContainsLocality(Locality locality)
        {
            bool b = false;
            for(int i=0; i<localities.Count; i++)
            {
                if (localities[i].city.Equals(locality.city))
                {
                    b = true;
                }
                else return false;
            }return b;
        }



        public bool AddPriseList(PriceList priceList)
        {
            if (!ContainsPriceList(priceList))
            {
                priceLists.Add(priceList);
                return true;
            }
            else return false;

        }



        public bool ContainsPriceList(PriceList priceList)
        {
            bool b = false;
            for (int i = 0; i < priceLists.Count; i++)
            {
                if (priceLists[i].ContainsDurationDate(priceList))
                {
                    b = true;
                }
                else return false;
            }
            return b;
        }


        public PriceList GetPriceListByDay(DateTime date)
        {
            for (int i = 0; i < priceLists.Count; i++)
            {
                if (priceLists[i].ContainsDate(date))
                {
                    return priceLists[i];
                }
               
            }
            return null;
            
        }



        public Locality GetLocacionByCity(String city)
        {
            Locality localityResult = null;

            foreach (Locality locality in localities)
            {
                if (locality.city.Equals(city))
                {
                    localityResult = locality;
                    break;
                }
            }

            return localityResult;
        }




        public override string ToString()
        {
            return nameTour;
        }


    }
}
