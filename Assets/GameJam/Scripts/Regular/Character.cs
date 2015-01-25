using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.GameJam.Scripts.Regular.Controllers;
using Assets.GameJam.Scripts.Regular.General;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.GameJam.Scripts.Regular
{
    public class Character : MyMonoBehaviour
    {
        private static int playerCount = 0;
        public Color SelectColor;

        void Start()
        {
            //BaseSoundController.Instance.PlaySoundByIndex(0, Vector2.zero)
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
            gameObject.GetComponentsInParent<Image>()[1].color = new Color(0.82f, 0.49f, 0f);
            BaseSoundController.Instance.PlaySoundByIndex(3, Vector2.zero);
            var MonkeyDescriptionComponent = new MonkeyDescription();
            GameController.Instance.MonkeyDescriptions.Add(MonkeyDescriptionComponent);
            playerCount++;
            Debug.Log("Selected Character " + playerCount);
        }

        public void Raider()
        {
            gameObject.GetComponentsInParent<Image>()[1].color = new Color(0.82f, 0.49f, 0f);
            BaseSoundController.Instance.PlaySoundByIndex(7, Vector2.zero);
            var MonkeyDescriptionComponent = new MonkeyDescription();
            GameController.Instance.MonkeyDescriptions.Add(MonkeyDescriptionComponent);
            playerCount++;
            Debug.Log("Selected Character " + playerCount);
        }

        public void Hunter()
        {
            gameObject.GetComponentsInParent<Image>()[1].color = new Color(0.82f, 0.49f, 0f);
            BaseSoundController.Instance.PlaySoundByIndex(8, Vector2.zero);
            var MonkeyDescriptionComponent = new MonkeyDescription();
            GameController.Instance.MonkeyDescriptions.Add(MonkeyDescriptionComponent);
            playerCount++;
            Debug.Log("Selected Character " + playerCount);
        }

        public void Prist()
        {
            gameObject.GetComponentsInParent<Image>()[1].color = new Color(0.82f, 0.49f, 0f);
            BaseSoundController.Instance.PlaySoundByIndex(10, Vector2.zero);
            var MonkeyDescriptionComponent = new MonkeyDescription();
            GameController.Instance.MonkeyDescriptions.Add(MonkeyDescriptionComponent);
            playerCount++;
            Debug.Log("Selected Character " + playerCount);
        }

        public void Spy()
        {
            gameObject.GetComponentsInParent<Image>()[1].color = new Color(0.82f, 0.49f, 0f);
            BaseSoundController.Instance.PlaySoundByIndex(11, Vector2.zero);
            var MonkeyDescriptionComponent = new MonkeyDescription();
            GameController.Instance.MonkeyDescriptions.Add(MonkeyDescriptionComponent);
            playerCount++;
            Debug.Log("Selected Character " + playerCount);
        }

        public void Merchant()
        {
            gameObject.GetComponentsInParent<Image>()[1].color = new Color(0.82f, 0.49f, 0f);
            BaseSoundController.Instance.PlaySoundByIndex(9, Vector2.zero);
            var MonkeyDescriptionComponent = new MonkeyDescription();
            GameController.Instance.MonkeyDescriptions.Add(MonkeyDescriptionComponent);
            playerCount++;
            Debug.Log("Selected Character " + playerCount);
        }


        public void GoToCharacterScreen()
        {
            BaseSoundController.Instance.PlaySoundByIndex(0, Vector2.zero);
            Application.LoadLevel("CharacterScene");
        }
  

    

    
    }
}
