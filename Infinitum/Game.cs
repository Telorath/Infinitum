using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infinitum
{
    class Game
    {

        private static Game instance = null;

        public bool playing = false;

        private Game()
        {
            //Empty private constructor prevents anyone else from creating a game object
        }

        public static Game Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Game();
                }
                return instance;
            }
        }

        public Room[,] Map
        {
            //Only provide a getter, no one is allowed to replace the entire map with a new map
            get;
            //Setter is private, only we may set the map
            private set;
        }

        public List<Mob> Mobs
        {
            get;
            //Only we may set the mob list
            private set;
        }

        public void init()
        {
            //Fill the map out with some stuff, create the player

        }

        public void play()
        {
            playing = true;

            while (playing)
            {
                foreach (Mob mob in Mobs)
                {
                    mob.Update();
                }
            }
        }
    }
}