using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Structural.Flyweight
{
    public class CarFlyweightFactory
    {
        private readonly Dictionary<string, CarFlyweight> _flyweights;

        public CarFlyweightFactory(IEnumerable<CarFlyweight> flyweights)
        {
            _flyweights = flyweights.ToDictionary(x => GenerateKey(x));
        }

        private string GenerateKey(CarFlyweight carFlyweight)
        {
            return $"{carFlyweight.Manufacturer}_{carFlyweight.Model}_{carFlyweight.Color}";
        }

        public CarFlyweight GetFlyweight(CarFlyweight carFlyweight)
        {
            var key = GenerateKey(carFlyweight);
            if (_flyweights.ContainsKey(key))
            {
                Console.WriteLine($"Używamy istniejącego obiektu: {key}");
                return _flyweights[key];
            }

            Console.WriteLine($"Tworzymy nowy obiekt: {key}");
            _flyweights.Add(key, carFlyweight);
            return carFlyweight;
        }

        public void ListFlyweights()
        {
            Console.WriteLine($"Posiadamy {_flyweights.Count} elementów:");
            _flyweights.ToList().ForEach(x => Console.WriteLine(x.Key));
        }
    }
}
