using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Special.Collision
{
    enum FCollisionState
    {
        Block,
        Ignore,
        Overlap
    }

    enum FSelectCollision
    {
        Actor,
        Character, 
        WorldObjects,
        Camera,
    }

    struct FCollision
    {
        public FCollisionState CollisionWithActor;
        public FCollisionState CollisionWithCharacter;
        public FCollisionState CollisionWithWorldObjects;
        public FCollisionState CollisionWithCamera;

        //Set all colision options to block 
        public void BlockAllCollision()
        {
            CollisionWithActor = FCollisionState.Block;
            CollisionWithCharacter = FCollisionState.Block;
            CollisionWithWorldObjects = FCollisionState.Block;
            CollisionWithCamera = FCollisionState.Block;
        }

        public void OverlapAllCollision()
        {
            //set all colision options to overlap 
            CollisionWithActor = FCollisionState.Overlap;
            CollisionWithCharacter = FCollisionState.Overlap;
            CollisionWithWorldObjects = FCollisionState.Overlap;
            CollisionWithCamera = FCollisionState.Overlap;
        }

        public void IgnoreAllCollision()
        {
            //Set all colision options to ignore
            CollisionWithActor = FCollisionState.Ignore;
            CollisionWithCharacter = FCollisionState.Ignore;
            CollisionWithWorldObjects = FCollisionState.Ignore;
            CollisionWithCamera = FCollisionState.Ignore;
        }
    }

    class GameCollision
    {
        public FCollision ActorCollision; 

        public static void ShowAllActorCollision()
        {

        }

        //Return NONE if is empty 
        public static string ShowCollisionByEnumSelect(FSelectCollision SelectedOption, GameCollision ActorCollision)
        {
            if(SelectedOption == FSelectCollision.Actor)
            {
                return ActorCollision.ActorCollision.CollisionWithActor.ToString();
            }

            if (SelectedOption == FSelectCollision.Camera)
            {
                return ActorCollision.ActorCollision.CollisionWithCamera.ToString();
            }

            if (SelectedOption == FSelectCollision.Character)
            {
                return ActorCollision.ActorCollision.CollisionWithCharacter.ToString();
            }

            if (SelectedOption == FSelectCollision.WorldObjects)
            {
                ActorCollision.ActorCollision.CollisionWithWorldObjects.ToString();
            }

            return "NONE";

        }
    }
}
