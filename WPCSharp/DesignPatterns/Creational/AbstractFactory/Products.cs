using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Creational.AbstractFactory
{
    public class HondaCompactSedan : ISedan
    {
        public string Name()
        {
            return "Honda Amaze";
        }
    }

    public class HondaFullSedan : ISedan
    {
        public string Name()
        {
            return "Honda Accord";
        }
    }

    public class HondaCompactSuv : ISuv
    {
        public string Name()
        {
            return "Honda CR-V";
        }
    }

    public class HondaFullSuv : ISuv
    {
        public string Name()
        {
            return "Honda Pilot";
        }
    }

    public class ToyotaCompactSedan : ISedan
    {
        public string Name()
        {
            return "Toyota Yaris";
        }
    }

    public class ToyotaFullSedan : ISedan
    {
        public string Name()
        {
            return "Toyota Camry";
        }
    }

    public class ToyotaCompactSuv : ISuv
    {
        public string Name()
        {
            return "Toyota Rav-4";
        }
    }

    public class ToyotaFullSuv : ISuv
    {
        public string Name()
        {
            return "Toyota Highlander";
        }
    }
}
