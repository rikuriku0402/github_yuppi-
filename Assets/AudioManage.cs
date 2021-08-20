using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManage : MonoBehaviour
{
    private new AudioSource audio;

    public AudioClip sound01;
    public AudioClip sound02;
    public AudioClip sound03;
    // Start is called before the first frame update
    void Start()
    {
        audio = gameObject.AddComponent<AudioSource>();
    }

   void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Pink")
        {
            audio.PlayOneShot(sound01);
        }
        else if (other.gameObject.tag == "Block")
        {
            audio.PlayOneShot(sound02);
        }
        else if (other.gameObject.tag == "Bar") 
            audio.PlayOneShot(sound03);
        }
    }
    
