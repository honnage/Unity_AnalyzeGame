using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource[] destroyNoise;

    public void PlayRandomDestroyNoise()
    {
        //Choose a random number
        int clipToPlaty = Random.Range(0, destroyNoise.Length);
        //play tht clip
        destroyNoise[clipToPlaty].Play();
    }

}
