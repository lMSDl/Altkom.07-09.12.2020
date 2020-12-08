using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Behavioral.Command
{
    public class PlantCommand : Command<Garden>
    {
        public PlantCommand(Garden garden, string plant) : base(garden, plant)
        {
        }

        public override bool Execute()
        {
            return _receiver.Plant(_plant);
        }

        public override void Undo()
        {
            _receiver.Remove(_plant);
        }
    }
}
