using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infinitum
{
    class Room
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public List<Mob> Mobs { get; private set; }

        public Room(int x, int y)
        {
            Mobs = new List<Mob>();
            X = x;
            Y = y;
        }        
    }
}
