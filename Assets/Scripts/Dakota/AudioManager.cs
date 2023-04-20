using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {
    private static AudioManager _instance;
    public static AudioManager Instance { get { return _instance; } }

    public AudioSource EffectsSource;
    public AudioSource MusicSource;
    public AudioClip[] sipClips;

    private void Awake() {
        if (_instance != null && _instance != this) {
            Destroy(this.gameObject);
        } else {
            _instance = this;
        }
        DontDestroyOnLoad(gameObject);
    }

    public void Play(AudioClip clip) {
        EffectsSource.clip = clip;
        EffectsSource.Play();
    }

    public void PlayMusic(AudioClip clip) {
        MusicSource.clip = clip;
        MusicSource.Play();
    }

    public void PlayRandomSipSound() {
        int randomIndex = Random.Range(0, sipClips.Length);

        EffectsSource.clip = sipClips[randomIndex];
        EffectsSource.Play();
    }


}
