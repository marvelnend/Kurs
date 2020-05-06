using System;
using System.Runtime.InteropServices;
namespace Kursova.models {
	public class BaseSystem {
		public List<Hotel> Hotels = new List<Hotel>();
		public List<Locality> Localities = new List<Locality>();
		public List<PriceList> PriceLists = new List<PriceList>();
		public List<Tour> Tours = new List<Tour>();

		public BaseSystem() {
			throw new System.Exception("Not implemented");
		}
		public bool RegisterHotel([Optional, DefaultParameterValueAttribute()]ref String name, [Optional, DefaultParameterValueAttribute()]ref int namberOfStars) {
			throw new System.Exception("Not implemented");
		}
		public Hotel GetHotelByName([Optional, DefaultParameterValueAttribute()]ref String name) {
			throw new System.Exception("Not implemented");
		}
		public Locality GetLocacionByCity([Optional, DefaultParameterValueAttribute()]ref String city) {
			throw new System.Exception("Not implemented");
		}
		public bool RegisterLocality([Optional, DefaultParameterValueAttribute()]ref String country, [Optional, DefaultParameterValueAttribute()]ref String city) {
			throw new System.Exception("Not implemented");
		}
		public bool AddHotelByName([Optional, DefaultParameterValueAttribute()]ref String city, [Optional, DefaultParameterValueAttribute()]ref String hotel) {
			throw new System.Exception("Not implemented");
		}
		public Tour GetTourByName([Optional, DefaultParameterValueAttribute()]ref String name) {
			throw new System.Exception("Not implemented");
		}
		public bool RegisterTour([Optional, DefaultParameterValueAttribute()]ref String name, [Optional, DefaultParameterValueAttribute()]ref String type, [Optional, DefaultParameterValueAttribute()]ref String transport, [Optional, DefaultParameterValueAttribute()]ref int durationDay, [Optional, DefaultParameterValueAttribute()]ref String city) {
			throw new System.Exception("Not implemented");
		}
		public bool AddLocalityByCity([Optional, DefaultParameterValueAttribute()]ref String nameTour, [Optional, DefaultParameterValueAttribute()]ref String city) {
			throw new System.Exception("Not implemented");
		}
		public bool AddPriseListByDai([Optional, DefaultParameterValueAttribute()]ref String nameTour, [Optional, DefaultParameterValueAttribute()]ref DateTime date, [Optional, DefaultParameterValueAttribute()]ref DateTime date2, [Optional, DefaultParameterValueAttribute()]ref int price, [Optional, DefaultParameterValueAttribute()]ref int pass) {
			throw new System.Exception("Not implemented");
		}

	}

}
