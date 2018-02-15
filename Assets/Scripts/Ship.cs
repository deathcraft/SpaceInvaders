using UnityEngine;

namespace SpaceInvaders
{
    public class Ship : InvaderObject
    {
        [SerializeField]
        public GameObject shot;

        private GameObject shotInstance;
        
        void Update()
        {
            ProcessKeyboard();
        }

        private void ProcessKeyboard()
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                MoveLeft();
            }
            
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                MoveRight();
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                CreateShot();
            }
        }

        private void CreateShot()
        {
//            if (shotInstance != null)
//            {
//                return;
//            }
            
            shotInstance = Instantiate(shot);
            shotInstance.transform.position = transform.position;
        }
    }
}