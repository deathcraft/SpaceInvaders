using UnityEngine;

namespace SpaceInvaders
{
    public class InvaderObject : MonoBehaviour
    {
        private Game game;

        private void Awake()
        {
            game = FindObjectOfType<Game>();
        }

        protected void MoveRight()
        {
            var transformPosition = transform.position;
            transformPosition.x += game.GridSize;
            transform.position = transformPosition;
        }

        protected  void MoveLeft()
        {
            var transformPosition = transform.position;
            transformPosition.x -= game.GridSize;
            transform.position = transformPosition;
        }
        
        protected void MoveUp()
        {
            var transformPosition = transform.position;
            transformPosition.y += game.GridSize;
            transform.position = transformPosition;
        }

        protected  void MoveDown()
        {
            var transformPosition = transform.position;
            transformPosition.y -= game.GridSize;
            transform.position = transformPosition;
        }
    }
}