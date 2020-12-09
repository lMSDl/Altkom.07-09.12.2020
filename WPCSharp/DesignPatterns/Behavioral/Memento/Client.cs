using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPCSharp.DesignPatterns.Behavioral.Iterator;
using WPCSharp.DesignPatterns.Behavioral.NullObject;

namespace WPCSharp.DesignPatterns.Behavioral.Memento
{
    public class Client
    {
        public static void Execute()
        {
            var person = new Person
            {
                Name = "Ewa Ewowska",
                BirthDate = new DateTime(1989, 12, 12)
            };

            var caretaker = new Caretaker<Person>(person);
            Console.WriteLine($"Name: {person.Name}");
            caretaker.Save();

            person.Name = "Monika Monikowska";
            Console.WriteLine($"Name: {person.Name}");
            caretaker.Save();

            var dateTime = DateTime.Now;

            person.Name = "Ewa Monikowska";
            Console.WriteLine($"Name: {person.Name}");
            caretaker.Save();

            person.Name = "Monika Ewowska";
            Console.WriteLine($"Name: {person.Name}");
            caretaker.Save();

            Console.WriteLine(caretaker);

            caretaker.Peek(dateTime);
            Console.WriteLine($"Name: {person.Name}");

            caretaker.Undo();
            Console.WriteLine($"Name: {person.Name}");
            caretaker.Undo();
            Console.WriteLine($"Name: {person.Name}");
            caretaker.Undo();
            Console.WriteLine($"Name: {person.Name}");

        }
    }
}
