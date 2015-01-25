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
        public Text PopulationText;
        public Text ResourcesText;
        public Text MoraleText;
        public Text CharacterName;
        public Text CharacterDescription;
        public Image CharacterPortrait;
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
            CharacterName.text = "Average Monkey";
            CharacterDescription.text = "Average Monkey enjoys long walks on the beach, eating bananas, and dancing around the campfire.";
            
        }

        public void UpdateText()
        {
            PopulationText.text = Population.ToString();
            ResourcesText.text = Resources.ToString();
            MoraleText.text = Morale.ToString();
        }

    }
}
