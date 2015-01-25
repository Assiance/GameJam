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

        void Start()
        {
           
        }

        void Update()
        {
     
        }

       

        public void Pirate()
        {
            GameController.Instance.MonkeyDescriptions.Add(GetComponent<MonkeyDescription>());
            playerCount++;
        }

        public void Raider()
        {
            int i = 0; GameController.Instance.MonkeyDescriptions.Add(GetComponent<MonkeyDescription>());
            playerCount++;
        }

        public void Hunter()
        {
            GameController.Instance.MonkeyDescriptions.Add(GetComponent<MonkeyDescription>());
            playerCount++;
        }

        public void Prist()
        {
            GameController.Instance.MonkeyDescriptions.Add(GetComponent<MonkeyDescription>());
            playerCount++;
        }

        public void Spy()
        {
            GameController.Instance.MonkeyDescriptions.Add(GetComponent<MonkeyDescription>());
            playerCount++;
        }

        public void Merchant()
        {
            GameController.Instance.MonkeyDescriptions.Add(GetComponent<MonkeyDescription>());
            playerCount++;
        }
  

    

    
    }
}
