using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_PRO
{
    internal class City
    {
        public int cityPopulation { get; set; }
        public static City operator +(City city1, City city2) => new City { cityPopulation = city1.cityPopulation + city2.cityPopulation };
        public static City operator -(City city1, City city2) => new City { cityPopulation = city1.cityPopulation - city2.cityPopulation };
        public static bool operator ==(City city1, City city2) => city1.cityPopulation == city2.cityPopulation;
        public static bool operator !=(City city1, City city2) => city1.cityPopulation != city2.cityPopulation;
        public static bool operator >(City city1, City city2) => city1.cityPopulation > city2.cityPopulation;
        public static bool operator <(City city1, City city2) => city1.cityPopulation < city2.cityPopulation;
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            City other = (City)obj;
            return cityPopulation == other.cityPopulation;
        }

        public static void TestCity()
        {
            City city = new City() { cityPopulation = 1_000_000 };
            City city2 = new City() { cityPopulation = 650_000 };
            City city3 = city + city2;
            Console.WriteLine($"Test overload for class City. \nStart value for class:\n1_000_000 people\n650_000 people");
            Console.WriteLine($"Result {city.cityPopulation} + {city2.cityPopulation} = {city3.cityPopulation}");
            city3 = city - city2;
            Console.WriteLine($"Result {city.cityPopulation} - {city2.cityPopulation} = {city3.cityPopulation}");
            bool info = city == city2;
            Console.WriteLine($"Result {city.cityPopulation} == {city2.cityPopulation} is a {info}");
            info = city > city2;
            Console.WriteLine($"Result {city.cityPopulation} > {city2.cityPopulation} is a {info}");
            info = city < city2;
            Console.WriteLine($"Result {city.cityPopulation} < {city2.cityPopulation} is a {info}");
            info = city != city2;
            Console.WriteLine($"Result {city.cityPopulation}  !=  {city2.cityPopulation} is a {info}");
            info = city.Equals(city2);
            Console.WriteLine($"Result method Equals for class City = {info}");
        }
    }
}
