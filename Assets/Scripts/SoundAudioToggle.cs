  using System;
using TMPro;
using UnityEngine;
  using UnityEngine.UI;

  public class SoundAudioToggle: MonoBehaviour
  {

      public TextMeshProUGUI text;
      public AudioSource[] audioSources;
      public bool on;

      private void Awake()
      {
          on = true;
      }

      public void click()
      {
          on = !on;
          int volume = 0;
          if (on)
          {
              volume = 1;
            text.text = "ON";
          }
          else
          {
            text.text = "OFF";
        }
          foreach (AudioSource audio in audioSources)
          {
              audio.volume = volume;
          }
      }
  }
