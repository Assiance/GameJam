using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.GameJam.Scripts.Regular.Choices;
using Assets.GameJam.Scripts.Regular.Events;
using Assets.GameJam.Scripts.Regular.General;
using Assets.GameJam.Scripts.Regular.Scenarios;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.GameJam.Scripts.Regular.Controllers
{
    public class StateController : MyMonoBehaviour
    {
        #region Singleton
        private static StateController _instance;
        public static StateController Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = GameObject.FindObjectOfType(typeof(StateController)) as StateController;
                    if (_instance == null)
                        _instance = new GameObject("StateController Temporary Instance", typeof(StateController)).GetComponent<StateController>();
                }
                return _instance;
            }
        }

        void Awake()
        {
            if (_instance == null)
            {
                _instance = this;
            }
        }
        #endregion

        public List<BaseScenario> Scenarios { get; set; }
        public List<BaseEvent> Events { get; set; }
        public List<PlayerStatus> PlayerStats { get; set; }
        public List<BaseChoice> Choices { get; set; }

        public Text PopulationText;
        public Text ResourcesText;
        public Text MoraleText;
        public Text CharacterName;
        public Image CharacterPortrait;
        public Text Scenario1Text;
        public Text Scenario2Text;
        public Text Scenario3Text;

        void Start()
        {
            PlayerStats = new List<PlayerStatus>();
            Events = new List<BaseEvent>();
            Scenarios = new List<BaseScenario>();
            Choices = new List<BaseChoice>();

            InitiateBrain();

            StartCoroutine(DeathCheck());
        }

        public void InitiateBrain()
        {
            PlayerStats = FindObjectsOfType<PlayerStatus>().ToList();

            foreach (var player in PlayerStats)
            {
                Events.AddRange(player.GetComponents<BaseEvent>());
                Scenarios.AddRange(player.GetComponents<BaseScenario>());
                Choices.AddRange(player.GetComponents<BaseChoice>());
            }
        }

        public PlayerStatus GetPlayerStatsByNumber(int playerNumber)
        {
            return PlayerStats.First(i => i.PlayerId == playerNumber);
        }

        public PlayerStatus SetActivePlayer(int playerNumber)
        {
            var player = PlayerStats.First(i => i.PlayerId == playerNumber);

            var monkeyDescription = GameController.Instance.MonkeyDescriptions[player.PlayerId - 1];
            PopulationText.text = player.Population.ToString();
            ResourcesText.text = player.Resources.ToString();
            MoraleText.text = player.Morale.ToString();
            CharacterName.text = monkeyDescription.Name;

            return player;
        }

        public void PlayerSwitch(PlayerStatus player)
        {
            var monkeyDescription = GameController.Instance.MonkeyDescriptions[player.PlayerId - 1];
            PopulationText.text = player.Population.ToString();
            ResourcesText.text = player.Resources.ToString();
            MoraleText.text = player.Morale.ToString();
            CharacterName.text = monkeyDescription.Name;
        }

        IEnumerator DeathCheck()
        {
            while (true)
            {
                PlayerStats.FindAll(i => i.Population <= 0 || i.Resources <= 0 || i.Morale <= 0).ForEach(i => i.IsAlive = false);
                yield return new WaitForSeconds(1f);
            }
        }

        IEnumerator WinCheck()
        {
            while (true)
            {
                if (PlayerStats.FindAll(i => i.IsAlive == true).Count == 1)
                {
                    GameController.Instance.Win();
                }

                yield return new WaitForSeconds(1f);
            }
        }
    }
}
