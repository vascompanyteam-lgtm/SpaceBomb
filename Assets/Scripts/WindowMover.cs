using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowMover : MonoBehaviour
{
    
    public GameObject mainMenu;
    public GameObject gamePlay;
    public GameObject settings;
    public Animator animator;
    public SoundAudio soundAudio;

    public void SetMainMenu()
    {
        ////////////////////////////////////
            animator.Play("Animation");
            mainMenu.SetActive(true);
            gamePlay.SetActive(false);
            settings.SetActive(false);
        soundAudio.playUIclick();
        
    }

    public void SetGamePlay()
    {

        ////////////////////////////////////
        animator.Play("Animation");
        soundAudio.playUIclick();
        gamePlay.SetActive(true);
        mainMenu.SetActive(false);
        settings.SetActive(false);

    }

    public void SetSettings()
    {
        ///////////////////////////
        animator.Play("Animation");
        soundAudio.playUIclick();
        gamePlay.SetActive(false);
        mainMenu.SetActive(false);
        settings.SetActive(true);

    }
}
