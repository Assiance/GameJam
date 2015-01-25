using System.Collections.Generic;
using System.Linq;
using Assets.GameJam.Scripts.Regular.General;
using UnityEngine;

namespace Assets.GameJam.Scripts.Regular.Controllers
{
    public class GameController : MyMonoBehaviour
    {
        #region Singleton
        private static GameController _instance;
        public static GameController Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = GameObject.FindObjectOfType(typeof(GameController)) as GameController;
                    if (_instance == null)
                        _instance = new GameObject("GameController Temporary Instance", typeof(GameController)).GetComponent<GameController>();
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

        public List<MonkeyDescription> MonkeyDescriptions;

        void Start()
        {
            MonkeyDescriptions = new List<MonkeyDescription>();
            DontDestroyOnLoad(transform.gameObject);
        }

        public void Win()
        {
            
        }

        public void Lose()
        {
            
        }
    }
}
