namespace GameBase
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance;

        // Items to save between scenes
        public bool playerClearedEvent;
        public int savedWayPointIndex;

        private void Awake()
        {
            if(Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(Instance);
            }
            else
            {
                Destroy(this.gameObject);
            }
        }

    }

}