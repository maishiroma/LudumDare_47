namespace Player
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class FollowPlayer : MonoBehaviour
    {
        public PlayerMovement playerObj;
        public Vector3 offset;

        private void Update()
        {
            if(playerObj.IsPlayerDead == false)
            {
                gameObject.transform.position = playerObj.transform.position + offset;
            }
        }
    }

}