using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.GameJam.Scripts.Regular.Choices;
using Assets.GameJam.Scripts.Regular.Events;
using Assets.GameJam.Scripts.Regular.General;
using Assets.GameJam.Scripts.Regular.Scenarios;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.GameJam.Scripts.Regular.Controllers
{
    public class PhaseController : MyMonoBehaviour
    {
        public int TotalRounds = 3;
        public int TotalPhases = 3;
        private int roundNumber;
        private int phaseNumber;
        public float RoundTime = 15f;
        public PlayerStatus ActivePlayer;

        public Text timerSeconds;
        public Text activePlayerName;

        void Start()
        {
            Debug.Log("Started!");
            AddScenariosToPlayers();
            AddEventsToPlayers();
            StateController.Instance.InitiateBrain();

            foreach (var theEvent in StateController.Instance.Events)
            {
                theEvent.Execute();
            }

            StartCoroutine(StartTimer());
        }

        IEnumerator StartTimer()
        {
            Debug.Log("Started Timer");

            Debug.Log("Go Player 1");
            activePlayerName.text = "Player 1";
            ActivePlayer = StateController.Instance.SetActivePlayer(1);
            
            if (ActivePlayer.IsAlive)
            {
                ActivePlayer.MyTurn = true;

                for (float i = 0f; i < RoundTime; i++)
                {
                    timerSeconds.text = (RoundTime - i).ToString();
                    yield return new WaitForSeconds(1);
                }

                ActivePlayer.MyTurn = false;
            }

            Debug.Log("Go Player 2");
            activePlayerName.text = "Player 2";
            ActivePlayer = StateController.Instance.SetActivePlayer(2);
            if (ActivePlayer.IsAlive)
            {
                ActivePlayer.MyTurn = true;

                for (float i = 0f; i < RoundTime; i++)
                {
                    timerSeconds.text = (RoundTime - i).ToString();
                    yield return new WaitForSeconds(1);
                }

                ActivePlayer.MyTurn = false;
            }

            Debug.Log("Go Player 3");
            activePlayerName.text = "Player 3";
            ActivePlayer = StateController.Instance.SetActivePlayer(3);
            if (ActivePlayer.IsAlive)
            {
                ActivePlayer.MyTurn = true;

                for (float i = 0f; i < RoundTime; i++)
                {
                    timerSeconds.text = (RoundTime - i).ToString();
                    yield return new WaitForSeconds(1);
                }

                ActivePlayer.MyTurn = false;
            }

            Debug.Log("Go Player 4");
            activePlayerName.text = "Player 4";
            ActivePlayer = StateController.Instance.SetActivePlayer(4);
            if (ActivePlayer.IsAlive)
            {
                ActivePlayer.MyTurn = true;

                for (float i = 0f; i < RoundTime; i++)
                {
                    timerSeconds.text = (RoundTime - i).ToString();
                    yield return new WaitForSeconds(1);
                }

                ActivePlayer.MyTurn = false;
            }

            CycleRound();
        }

        public void CycleRound()
        {
            Debug.Log("Cycle The Round");
            Debug.Log("Executing Choices");
            foreach (var player in StateController.Instance.PlayerStats)
            {
                var choices = player.gameObject.GetComponents<BaseChoice>();

                foreach (IChoice choice in choices.Where(i => i.DoExecute == true))
                {
                    choice.Execute();
                }
            }

            Debug.Log("Update Players");
            //UpdatePlayers();

            if (roundNumber < TotalRounds)
            {
                roundNumber++;
                StartNewRound();
            }
            else
            {
                roundNumber = 0;
                Debug.Log("Cycle Phase");
                CyclePhase();
            }
        }

        public void CyclePhase()
        {
            foreach (var scenario in StateController.Instance.Scenarios)
            {
                scenario.Execute();
            }

            if (phaseNumber < TotalPhases)
            {
                phaseNumber++;
                roundNumber = 0;
                StartNewRound();
            }
            else
            {
                GameController.Instance.Win();
            }
        }

        public void StartNewRound()
        {
            ResetChoices();
            StartCoroutine(StartTimer());
        }

        public void ResetChoices()
        {
            foreach (var choice in StateController.Instance.Choices)
            {
                choice.DoExecute = false;
            }
        }

        public void AddScenariosToPlayers()
        {
            Debug.Log("Adding Scenarios to Players");

            var scenarios = new Dictionary<int, string>{
                {1, "OverConsumptionScenario"},
                {2, "OverWorkingScenario"},
                {3, "PlagueScenario"},
                {4, "WildPantherScenario"}
            };


            //Add Random Scenarios
            foreach (var player in StateController.Instance.PlayerStats)
            {
                // So we know what not to add to avoid duplicates
                var scenarioIds = new List<int>();

                // Get a random ID
                var scenario1 = GetRandom(scenarios.Count);

                // Add it to the list to avoid duplicates
                scenarioIds.Add(scenario1);

                // Add the component
                var value = scenarios.FirstOrDefault(x => x.Key == scenario1).Value;
                if (value != null)
                {
                    Debug.Log("Successfully added scenario 1");
                    player.gameObject.AddComponent(value);
                }
                // Repeat for scenario 2 and 3
                var scenario2 = GetRandom(scenarios.Count, 0, scenarioIds);
                scenarioIds.Add(scenario2);
                value = scenarios.FirstOrDefault(x => x.Key == scenario2).Value;
                if (value != null)
                {
                    Debug.Log("Succesfully added scenario 2");
                    player.gameObject.AddComponent(value);
                }
                var scenario3 = GetRandom(scenarios.Count, 0, scenarioIds);
                value = scenarios.FirstOrDefault(x => x.Key == scenario3).Value;
                if (value != null)
                {
                    Debug.Log("Succesfully added scenario 3");
                    player.gameObject.AddComponent(value);
                }

                // No need to add scenario 3 to the list as we're done now.
            }
        }

        private int GetRandom(int max, int min = 0, List<int> whereNotInThisList = null)
        {
            if (whereNotInThisList == null)
                whereNotInThisList = new List<int>();

            var rand = new System.Random();
            var retVal = rand.Next(min, max);
            if (whereNotInThisList.Contains(retVal))
                return GetRandom(max, min, whereNotInThisList);

            return retVal;
            
        }

        public void AddEventsToPlayers()
        {
            Debug.Log("Adding Events to Players");
            
            var events = new Dictionary<int, string>{
                {1, "CoconutAbundanceEvent"},
                {2, "HurricaneEvent"},
                {3, "LocustSwarmEvent"},
                {4, "MonkeyShowersEvent"},
                {5, "MonkeyWashUpEvent"},
                {6, "PantherAttackEvent"},
                {7, "ScienceBookDiscoveryEvent"},
                {8, "TornadoEvent"},
                {9, "TsunamiEvent"},
                {10, "VolcanoEvent"}
            };


            //Add Random Events
            foreach (var player in StateController.Instance.PlayerStats)
            {
                // Get a random ID
                var event1 = GetRandom(events.Count, 1);

                // Add the component
                var value = events.FirstOrDefault(x => x.Key == event1).Value;
                if(value != null)
                {
                    Debug.Log("Successfully Added Event");
                    player.gameObject.AddComponent(value);
                }
            }
        }

        public void SelectGather()
        {

            BaseSoundController.Instance.PlaySoundByIndex(3, Vector2.zero);
            ActivePlayer.GetComponent<GatherChoice>().DoExecute = true;
        }

        public void SelectRaid()
        {
            BaseSoundController.Instance.PlaySoundByIndex(3, Vector2.zero);
            ActivePlayer.GetComponent<RaidChoice>().DoExecute = true;
        }
        public void SelectScout()
        {
            BaseSoundController.Instance.PlaySoundByIndex(3, Vector2.zero);
            ActivePlayer.GetComponent<ScoutChoice>().DoExecute = true;
        }

        public void SelectTrade()
        {
            BaseSoundController.Instance.PlaySoundByIndex(3, Vector2.zero);
            ActivePlayer.GetComponent<TradeChoice>().DoExecute = true;
        }

        public void SelectWorship()
        {
            BaseSoundController.Instance.PlaySoundByIndex(3, Vector2.zero);
            ActivePlayer.GetComponent<WorshipChoice>().DoExecute = true;
        }
    }
}
