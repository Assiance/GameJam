using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.GameJam.Scripts.Regular.General;
using UnityEngine;

namespace Assets.GameJam.Scripts.Regular
{
    public class StartGame : MyMonoBehaviour
    {
        public void StartTheGame()
        {

            BaseSoundController.Instance.PlaySoundByIndex(0, Vector2.zero);
            Application.LoadLevel("StoryScene");
        }
    }
}
