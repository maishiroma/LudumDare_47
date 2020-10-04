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

        public int roundsSurvived;

        private void Awake()
        {
            if(Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(Instance);

                playerClearedEvent = false;
                savedWayPointIndex = 0;
                roundsSurvived = 0;
            }
            else
            {
                Destroy(this.gameObject);
            }
        }

        public void ResetSavedData()
        {
            playerClearedEvent = false;
            savedWayPointIndex = 0;
            roundsSurvived = 0;
        }

    }

}