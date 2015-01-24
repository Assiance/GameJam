using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.GameJam.Scripts.Regular.Choices;
using Assets.GameJam.Scripts.Regular.General;
using UnityEngine;

namespace Assets.GameJam.Scripts.Regular.Controllers
{
    public class PhaseController : MyMonoBehaviour
    {
        public int TotalRounds;
        public int TotalPhases;
        private int RoundNumber = 3;
        private int PhaseNumber = 3;
        public float RoundTime = 15f;

        void Start()
        {
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
            Debug.Log("Exeecuting Choices");
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

            if (RoundNumber < TotalRounds)
            {
                RoundNumber++;
                StartNewRound();
            }
            else
            {
                RoundNumber = 0;
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

            if (PhaseNumber < TotalPhases)
            {
                PhaseNumber++;
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
    }
}
