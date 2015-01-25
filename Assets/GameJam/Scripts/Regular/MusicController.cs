using UnityEngine;

namespace Assets.GameJam.Scripts.Regular
{
    public class MusicController : MonoBehaviour
    {
        private float _volume = 25f;
        private AudioSource _source;
        private GameObject _sourceGameObject;
        private int _fadeState;
        private int _targetFadeState;
        private float _volumeOn = 50f;
        private float _targetVolume;

        public string GamePrefsName = "DefaultGame";
        public AudioClip Music;
        public bool LoopMusic;
        public float FadeTime = 15f;
        public bool ShouldFadeInAtStart = true;

        void Start()
        {
            _volumeOn = PlayerPrefs.GetFloat(GamePrefsName + "_MusicVol", _volumeOn);
            _sourceGameObject = new GameObject("Music_AudioSource");
            _source = _sourceGameObject.AddComponent<AudioSource>();
            _source.name = "MusicAudioSource";
            _source.playOnAwake = true;
            _source.clip = Music;
            _source.volume = _volume;
        }

        void Update()
        {
            if (!_source.isPlaying && LoopMusic)
                _source.Play();
        }

        public void FadeIn(float fadeAmount)
        {
            _volume = 0;
            _fadeState = 0;
            _targetFadeState = 1;
            _targetVolume = _volumeOn;
            FadeTime = fadeAmount;
        }

        public void FadeOut(float fadeAmount)
        {
            _volume = _volumeOn;
            _fadeState = 1;
            _targetFadeState = 0;
            _targetVolume = 0;
            FadeTime = fadeAmount;
        }
    }
}
