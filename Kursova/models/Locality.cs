using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova.models
{
    public class Locality
    {
        public String country;
        public String city;
        public List<Hotel> hotels;



        public Locality(String country, String city)
        {
            this.country = country;
            this.city = city;
            hotels = new List<Hotel>();
        }



        public void AddHotel(Hotel hotel)
        {
            hotels.Add(hotel);
        }




        public override string ToString()
        {
            return country + " " + city;
        }


        public bool IsHotel()
        {
            return hotels.Count > 0;
        }



        public Hotel GetHotelByName(String name)
        {
            Hotel hotelResult = null;

            foreach (Hotel hotel in hotels)
            {
                if (hotel.hotelName.Equals(name))
                {
                    hotelResult = hotel;
                    break;
                }
            }

            return hotelResult;
        }


        


    }
}
