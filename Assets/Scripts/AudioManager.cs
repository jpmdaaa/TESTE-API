using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioClip SoundWin;
    public static AudioClip SoundLose;

    void Start()
    {
        SoundWin = Resources.Load<AudioClip>("Audio/Win");
        SoundLose = Resources.Load<AudioClip>("Audio/Lose");
    }

    public void PlaySoundWin()
    {
        gameObject.GetComponent<AudioSource>().PlayOneShot(SoundWin,10);

    }

    public void PlaySoundLose()
    {
        gameObject.GetComponent<AudioSource>().PlayOneShot(SoundLose,2);
    }

}
