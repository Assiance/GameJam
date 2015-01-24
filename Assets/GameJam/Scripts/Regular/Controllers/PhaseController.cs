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

namespace Assets.GameJam.Scripts.Regular.Controllers
{
    public class PhaseController : MyMonoBehaviour
    {
        public int TotalRounds = 3;
        public int TotalPhases = 3;
        private int roundNumber;
        private int phaseNumber;
        public float RoundTime = 15f;

        void Start()
        {
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
            yield return new WaitForSeconds(RoundTime);
            CycleRound();
        }

        public void CycleRound()
        {
            Debug.Log("Cycle The Round");
            Debug.Log("Executing Choices");
            foreach (var player in StateController.Instance.PlayerStats)
            {
                var choices = player.gameObject.GetComponents<BaseChoice>();

                foreach (IChoice choice in choices.Where(i => i.DoExecute == false))
                {
                    choice.Execute();
                }
            }

            Debug.Log("Update Players");
            UpdatePlayers();

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
                //StateController NewPhas
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
                //StateController InitiatePHase
            }
            else
            {
                //END GAME
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

        public void UpdatePlayers()
        {
            foreach (var player in StateController.Instance.PlayerStats)
            {
                player.UpdateText();
            }
        }

        public void AddScenariosToPlayers()
        {
            Debug.Log("Adding Scenarios to Players");
            //TODO: Add Random Scenarios
            foreach (var player in StateController.Instance.PlayerStats)
            {
                player.gameObject.AddComponent<OverConsumptionScenario>();
            }
        }

        public void AddEventsToPlayers()
        {
            Debug.Log("Adding Events to Players");
            //TODO: Add Random Scenarios
            foreach (var player in StateController.Instance.PlayerStats)
            {
                player.gameObject.AddComponent<TornadoEvent>();
            }
        }
    }
}
