using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SEManager : MonoBehaviour
{
    public AudioSource audio;
    public bool fade;
    // Start is called before the first frame update
    void Start()
    {
        audio.volume = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (fade)
        {
            audio.volume += 0.001f;
        }
    }
    public void buttonSound()
    {
        audio.volume = 1f;
        this.GetComponent<AudioSource>().enabled = true;
        this.GetComponent<AudioSource>().enabled = false;

    }
}
