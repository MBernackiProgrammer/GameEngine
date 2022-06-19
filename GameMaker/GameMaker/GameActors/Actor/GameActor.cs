using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Special.Collision;

namespace Actors.WorldActor
{
    
    class GameActor
    {
        GameCollision ObjectCollision = new GameCollision();

        public bool IsVisible = true;
        public bool IsHiddenInGame = false;

        public bool IsMoveAble = true;

        //public bool 
        //On events
        static public void EventBeginPlay()
        {

        }
        static public void SetCollision()
        {

        }

    }
}
