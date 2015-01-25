using UnityEngine;
using System.Collections;
using Assets.GameJam.Scripts.Regular.General;
using Assets.GameJam.Scripts.Regular;

namespace Assets.GameJam.Scripts.Regular
{
    public class StorySound : MyMonoBehaviour
    {

        // Use this for initialization
        void Start()
        {

            StartCoroutine(PlaySound());
        }

        IEnumerator PlaySound()
        {
            yield return new WaitForSeconds(.5f);
            BaseSoundController.Instance.PlaySoundByIndex(1, Vector2.zero);
        }

        // Update is called once per frame
        void Update()
        {
            
        }
    }
}
