using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class ModeManagerNight : MonoBehaviour
{
    public Image[] images;
    public SoundAudio soundAudio;
    private bool on = true;
    public TextMeshProUGUI text;
    
    private void Start()
    {
     
        
    }

    public void Click()
    {
        soundAudio.playUIclick();
        on = !on; 
        if(on)
        {
            text.text = "ON";
        }
        else { text.text = "OFF"; }
        float value = on ? 1f : 0.5f; 
        Color newColor = new Color(value, value, value);

        
        foreach (Image im in images)
        {
            if (im != null)
            {
                im.color = newColor;
            }
        }

       
    }
    
}
