using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{

    public GameObject pause;
    public AudioSource music;
    // Start is called before the first frame update
    void Start()
    {
        pause.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!pause.activeInHierarchy)
            {
                Pause();
            }
            else
            {
                Unpause();
            }
        }
    }
    public void Pause()
    {
        Time.timeScale = 0;
        pause.SetActive(true);
        music.Pause();
        
    }

    public void Unpause()
    {
        Time.timeScale = 1;
        pause.SetActive(false);
        music.Play();
     
    }
    
}
