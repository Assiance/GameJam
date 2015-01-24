using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.GameJam.Scripts.Regular.General;
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

        public List<IScenario> Scenarios { get; set; }
        public List<IEvent> Events { get; set; }
        public List<PlayerStats> PlayerStats { get; set; }
        public List<GameObject> Players { get; set; } 

        void Start()
        {

            //Players = FindObjectsOfType<PlayerStats>().ToList();
            //Scenarios = fin
        }

        public PlayerStats GetPlayerStatsByNumber(int playerNumber)
        {
            return PlayerStats.First(i => i.PlayerId == playerNumber);
        }

       

    }
}
