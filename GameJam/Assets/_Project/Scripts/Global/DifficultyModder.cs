namespace GameBase
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using Terrain;

    public class DifficultyModder : MonoBehaviour
    {
        private KillZone[] allKillZones;

        private void Start()
        {
            allKillZones = GameObject.FindObjectsOfType<KillZone>();

            foreach(KillZone currZone in allKillZones)
            {
                currZone.ModifiyDifficulty(GameManager.Instance.roundsSurvived);
            }
        }


    }

}