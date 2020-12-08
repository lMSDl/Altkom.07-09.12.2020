using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Behavioral.Command
{
    public class Garden
    {
        public int Size { get; }
        private List<string> Plants { get; set; } = new List<string>();
        public Garden(int size)
        {
            Size = size;
        }

        public bool Plant(string name)
        {
            if(Plants.Count < Size)
            {
                Plants.Add(name);
                Console.WriteLine($"Zasadziliśmy {name}");
                return true;
            }
            Console.WriteLine($"Brak miejsca na {name}");
            return false;
        }

        public bool Remove(string name)
        {
            if(Plants.Any(x => x == name))
            {
                Plants.Remove(name);
                Console.WriteLine($"{name} usunięto z ogrodu");
                return true;
            }
            Console.WriteLine($"Nie ma w ogodzie {name}");
            return false;
        }

        public override string ToString()
        {
            Console.WriteLine();
            Plants.ToList().ForEach(x => Console.WriteLine(x));
            return $"W ogorodzie jest {Plants.Count} roślin";
        }
    }
}
