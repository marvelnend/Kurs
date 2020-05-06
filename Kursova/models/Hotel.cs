using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova.models
{
    public class Hotel
    {
        public String hotelName;
        public int namberOfStars;

        public Hotel(String hotelName, int namberOfStars)
        {
            this.hotelName = hotelName;
            this.namberOfStars = namberOfStars;
        }
        public override string ToString()
        {
            return hotelName.ToString() + ", " + namberOfStars.ToString() + "*";
        }

    }
}
