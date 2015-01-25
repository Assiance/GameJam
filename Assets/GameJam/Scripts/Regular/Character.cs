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
        private static int playerCount = 0;

        void Start()
        {
        }

        void Update()
        {
            if (playerCount == 4)
            {
                Application.LoadLevel("MainScene");
            }
        }

        public void Pirate()
        {
            var MonkeyDescriptionComponent = new MonkeyDescription();
            GameController.Instance.MonkeyDescriptions.Add(MonkeyDescriptionComponent);
            playerCount++;
            Debug.Log("Selected Character " + playerCount);
        }

        public void Raider()
        {
            var MonkeyDescriptionComponent = new MonkeyDescription();
            GameController.Instance.MonkeyDescriptions.Add(MonkeyDescriptionComponent);
            playerCount++;
            Debug.Log("Selected Character " + playerCount);
        }

        public void Hunter()
        {
            var MonkeyDescriptionComponent = new MonkeyDescription();
            GameController.Instance.MonkeyDescriptions.Add(MonkeyDescriptionComponent);
            playerCount++;
            Debug.Log("Selected Character " + playerCount);
        }

        public void Prist()
        {
            var MonkeyDescriptionComponent = new MonkeyDescription();
            GameController.Instance.MonkeyDescriptions.Add(MonkeyDescriptionComponent);
            playerCount++;
            Debug.Log("Selected Character " + playerCount);
        }

        public void Spy()
        {
            var MonkeyDescriptionComponent = new MonkeyDescription();
            GameController.Instance.MonkeyDescriptions.Add(MonkeyDescriptionComponent);
            playerCount++;
            Debug.Log("Selected Character " + playerCount);
        }

        public void Merchant()
        {
            var MonkeyDescriptionComponent = new MonkeyDescription();
            GameController.Instance.MonkeyDescriptions.Add(MonkeyDescriptionComponent);
            playerCount++;
            Debug.Log("Selected Character " + playerCount);
        }


        public void GoToCharacterScreen()
        {
            Application.LoadLevel("CharacterScene");
        }
  

    

    
    }
}
