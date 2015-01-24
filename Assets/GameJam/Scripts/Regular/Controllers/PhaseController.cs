using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.GameJam.Scripts.Regular.General;
using UnityEngine;

namespace Assets.GameJam.Scripts.Regular.Controllers
{
    public class PhaseController : MyMonoBehaviour
    {
        #region Singleton
        private static PhaseController _instance;
        public static PhaseController Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = GameObject.FindObjectOfType(typeof(PhaseController)) as PhaseController;
                    if (_instance == null)
                        _instance = new GameObject("PhaseController Temporary Instance", typeof(PhaseController)).GetComponent<PhaseController>();
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

        public int TotalRounds;
        public int TotalPhases;
        private int RoundNumber;
        private int PhaseNumber;

        public void CycleRound()
        {
            //execute all choices
            //plus 1 to 
  
        }

        public void CycleScenario()
        {
            
        }
    }
}
