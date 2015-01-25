using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.GameJam.Scripts.Regular.Controllers;
using Assets.GameJam.Scripts.Regular.General;
using UnityEngine;

namespace Assets.GameJam.Scripts.Regular
{
    public class Character : MyMonoBehaviour
    {
        public MonkeyDescription MonkeyDescription;

        private static int playerCount = 1;

        void Update()
        {
            if (playerCount == 4)
            {
                Application.LoadLevel("GameScene");
            }
        }

        public void Pirate()
        {
            GameController.Instance.MonkeyDescriptions.Add(GetComponent<MonkeyDescription>());
            playerCount++;
            Debug.Log("Selected Character " + playerCount);
        }

        public void Raider()
        {
            int i = 0; GameController.Instance.MonkeyDescriptions.Add(GetComponent<MonkeyDescription>());
            playerCount++;
            Debug.Log("Selected Character " + playerCount);
        }

        public void Hunter()
        {
            GameController.Instance.MonkeyDescriptions.Add(GetComponent<MonkeyDescription>());
            playerCount++;
            Debug.Log("Selected Character " + playerCount);
        }

        public void Prist()
        {
            GameController.Instance.MonkeyDescriptions.Add(GetComponent<MonkeyDescription>());
            playerCount++;
            Debug.Log("Selected Character " + playerCount);
        }

        public void Spy()
        {
            GameController.Instance.MonkeyDescriptions.Add(GetComponent<MonkeyDescription>());
            playerCount++;
            Debug.Log("Selected Character " + playerCount);
        }

        public void Merchant()
        {
            GameController.Instance.MonkeyDescriptions.Add(GetComponent<MonkeyDescription>());
            playerCount++;
            Debug.Log("Selected Character " + playerCount);
        }
  

    

    
    }
}
