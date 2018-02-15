using System;
using UnityEngine;

namespace SpaceInvaders
{
    public class Shot : InvaderObject
    {
        [SerializeField]
        private float moveInterval;


        private float elapsed;
        
        void Update()
        {
            elapsed += Time.deltaTime;

            if (elapsed >= moveInterval)
            {
                MoveUp();
                elapsed = 0;
            }
            
        }
    }
}