using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infinitum
{
    class Mob
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int XPosition { get; private set; }
        public int YPosition { get; private set; }

        public void Move(int x, int y)
        {
            CurrentRoom.Mobs.Remove(this);
            XPosition = x;
            YPosition = y;
            CurrentRoom.Mobs.Add(this);
        }

        public Room CurrentRoom
        {
            get { return Game.Instance.Map[XPosition, YPosition]; }
        }

        public virtual void Update()
        {
            //Mobs do nothing since they have no AI or player to control them
        }
    }
}
