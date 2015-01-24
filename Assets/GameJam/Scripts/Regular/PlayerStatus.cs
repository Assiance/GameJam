using Assets.GameJam.Scripts.Regular.General;
using System;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.GameJam.Scripts.Regular.General;

namespace Assets.GameJam.Scripts.Regular
{
    public class PlayerStatus : MyMonoBehaviour
    {
        public Text PopulationText;
        public Text ResourcesText;
        public Text MoraleText;
        public Button myButton;

        public int PlayerId { get; set; }
        public int Population;
        public int Resources;
        public int Morale;
        public double SkillMultiplier = 1.0;
        public string Skill { get; set; }
        public string Name;

        void Start()
        {
            PopulationText.text = Population.ToString();
            ResourcesText.text = Resources.ToString();
            MoraleText.text = Morale.ToString();
        }

        public void UpdateText()
        {
            PopulationText.text = Population.ToString();
            ResourcesText.text = Resources.ToString();
            MoraleText.text = Morale.ToString();
        }

    }
}
