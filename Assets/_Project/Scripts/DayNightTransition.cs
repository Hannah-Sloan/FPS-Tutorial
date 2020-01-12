using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class DayNightTransition : MonoBehaviour
{

    public AudioMixerSnapshot snapshot;

    void Start()
    {
        snapshot.TransitionTo(8f);
    }
}
