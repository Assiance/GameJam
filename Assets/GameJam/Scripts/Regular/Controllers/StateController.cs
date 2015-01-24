using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.GameJam.Scripts.Regular.Choices;
using Assets.GameJam.Scripts.Regular.Events;
using Assets.GameJam.Scripts.Regular.General;
using Assets.GameJam.Scripts.Regular.Scenarios;
using UnityEngine;

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

        void Start()
        {
            PlayerStats = new List<PlayerStatus>();
            Events = new List<BaseEvent>();
            Scenarios = new List<BaseScenario>();
            Choices = new List<BaseChoice>();

            var players = FindObjectsOfType<PlayerStatus>();
            foreach (var player in players)
            {
                PlayerStats.Add(player.GetComponent<PlayerStatus>());
                Events.Add(player.GetComponent<BaseEvent>());
                Scenarios.Add(player.GetComponent<BaseScenario>());
                Choices.Add(player.GetComponent<BaseChoice>());
            }
        }

        public PlayerStatus GetPlayerStatsByNumber(int playerNumber)
        {
            return PlayerStats.First(i => i.PlayerId == playerNumber);
        }
    }
}
