using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infinitum
{
    class Player : Mob
    {

        private void GetInput()
        {
            //Fill out code to allow the player to provide input
        }

        private void DisplayRoom()
        {
            //Fill out code to display the room is currently in.
        }

        public override void Update()
        {
            DisplayRoom();
            GetInput();
        }
    }
}
