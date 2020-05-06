using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova.models
{
    public class PriceList
    {
        public DateTime dateTimeA;
        public DateTime dateTimeB;
        public int price;
        public int pass;


        public PriceList(DateTime dateTimeA, DateTime dateTimeB, int price, int pass)
        {
            this.dateTimeA = dateTimeA;
            this.dateTimeB = dateTimeB;
            this.price = price;
            this.pass = pass;
        }

        public bool ContainsDate(DateTime dateTime)
        {
            if (dateTime.Year >= dateTimeA.Year && dateTime.Year <= dateTimeB.Year)
            {
                if (dateTime.Month >= dateTimeA.Month && dateTime.Month <= dateTimeB.Month)
                {
                    if (dateTime.Day >= dateTimeA.Day && dateTime.Day <= dateTimeB.Day)
                    {
                        return true;
                    }
                    else return false;
                }
                else return false;
            }
            else return false;

        }



        public bool ContainsDurationDate(PriceList priceList)
        {
            return ContainsDate(priceList.dateTimeA) || ContainsDate(priceList.dateTimeB);
        }



        public bool IsPass()
        {
            return pass > 0;
        }



    }
}
