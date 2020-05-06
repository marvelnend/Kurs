using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova.models
{
    public class BaseSystem
    {
        public List<Hotel> hotels = new List<Hotel>();
        public List<Locality> localities = new List<Locality>();
        public List<PriceList> priceLists = new List<PriceList>();
        public List<Tour> tours = new List<Tour>();

        public BaseSystem()
        {

        }
        public bool RegisterHotel(String name, int namberOfStars)
        {
            if (!name.Equals("") && namberOfStars >= 0 && GetHotelByName(name) == null && namberOfStars<=5)
            {
                Hotel hotel = new Hotel(name, namberOfStars);
                hotels.Add(hotel);
                return true;
            }
            else return false;
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
        public bool RegisterLocality(String country, String city)
        {
            if (!country.Equals("") && !city.Equals("") && GetLocacionByCity(city) == null)
            {
                Locality locality = new Locality(country, city);
                localities.Add(locality);
                return true;
            }
            else return false;
        }



        public bool AddHotelByName(String city, String hotel)
        {
            if (GetLocacionByCity(city) != null && GetHotelByName(hotel) != null)
            {
                if (GetLocacionByCity(city).GetHotelByName(hotel) == null)
                {
                    GetLocacionByCity(city);
                    return true;
                }
                else return false;
            }
            else return false;
        }



        public Tour GetTourByName(String name)
        {
            Tour tourRezult = null;

            foreach (Tour tour in tours)
            {
                if (tour.nameTour.Equals(name))
                {
                    tourRezult = tour;
                    break;
                }
            }

            return tourRezult;
        }



        public bool RegisterTour(String name, String type, String transport, int durationDay, String city)
        {
            if (!name.Equals("") && !type.Equals("") && !transport.Equals("") && durationDay!=0 && !city.Equals("") 
                && GetTourByName(name) == null&& GetLocacionByCity(city) != null)
            { 
                    Tour tour = new Tour(name, type, transport, durationDay, GetLocacionByCity(city));
                    tours.Add(tour);
                    return true;
                
            }
            else return false;
        }





        public bool AddLocalityByCity(String nameTour, String city)
        {
            if (GetTourByName(nameTour) != null && GetLocacionByCity(city) != null)
            {
                if (GetTourByName(nameTour).GetLocacionByCity(city) == null)
                {
                    GetTourByName(nameTour).AddLocality(GetLocacionByCity(city));
                    return true;
                }
                else return false;
            }
            else return false;
        }




        public bool AddPriseListByDai(String nameTour, DateTime date, DateTime date2, int price, int pass)
        {
            if (GetTourByName(nameTour) != null)
            {
                if (GetTourByName(nameTour).GetPriceListByDay(date) == null)
                {
                    GetTourByName(nameTour).AddPriseList(new PriceList(date, date2, price, pass));
                    return true;
                }
                else return false;
            }
            else return false;
        }





    }
}