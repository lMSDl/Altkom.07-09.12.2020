using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Structural.Adapter.I
{
    public class SquareToCircleAdapter : ICircle
    {
        private Square _square;

        public SquareToCircleAdapter(Square square)
        {
            _square = square;
        }

        public float Radius => _square.Width * (float)Math.Sqrt(2) / 2f;
    }
}
