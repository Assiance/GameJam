using Assets.GameJam.Scripts.Regular.Controllers;
using Assets.GameJam.Scripts.Regular.General;
using System;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.GameJam.Scripts.Regular.General;

namespace Assets.GameJam.Scripts.Regular
{
    [Serializable]
    public class PlayerStatus : MyMonoBehaviour
    {
        public int PlayerId;
        public bool IsAlive = true;
        public int Population;
        public int Resources;
        public int Morale;
        public double SkillMultiplier = 1.0;
        public string Skill { get; set; }
        public string Name;
        public bool MyTurn = false;

        void Start()
        {
            //var monkeyDescription = GameController.Instance.MonkeyDescriptions[PlayerId];
            //PopulationText.text = Population.ToString();
            //ResourcesText.text = Resources.ToString();
            //MoraleText.text = Morale.ToString();
            //CharacterName.text = monkeyDescription.Name;
            //CharacterDescription.text = monkeyDescription.Description;

        }
    }
}
