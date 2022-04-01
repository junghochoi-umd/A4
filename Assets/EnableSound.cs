using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableSound : MonoBehaviour
{
    // Start is called before the first frame update

    AudioSource m_MyAudioSource;
    //Play the music
    bool m_Play;
    //Detect when you use the toggle, ensures music isn’t played multiple times
    void Start(){
        //Fetch the AudioSource from the GameObject
        m_MyAudioSource = GetComponent<AudioSource>();

        m_MyAudioSource.Stop();
        //Ensure the toggle is set to true for the music to play at start-up

        m_Play = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.B)) {
            if (m_Play) {
                m_MyAudioSource.Play();
            } else {
                m_MyAudioSource.Stop();
            }

            m_Play = !m_Play;
        } 

    }
}
