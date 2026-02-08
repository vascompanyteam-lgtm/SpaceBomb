using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundAudio : MonoBehaviour
{
    public AudioSource music;
    public AudioSource sound;

    public AudioClip clickUISound;
    public AudioClip successSound;
    public AudioClip dailySound;
    public AudioClip badSound;

    


    public void setVolume(float vol)
    {
        music.volume = vol;
        sound.volume = vol;
        

    }
    public void playDailySound()
    {
        sound.clip = dailySound;
        sound.Play();
    }

    public void playUIclick()
    {
        sound.clip = clickUISound;
        sound.Play();
    }

    public void playBadSound()
    {
        sound.clip = badSound;
        sound.Play();
    }
    
    public void playSuccessSound()
    {
        sound.clip = successSound;
        sound.Play();
    }

   

}
