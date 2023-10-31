using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayCube : MonoBehaviour
{
    public GameObject starttargetPosition;
    public GameObject endtargetPosition;
    public AudioClip startsound;
    public AudioClip endsound;
    public AudioClip sound;
    
    public void Startgame()
    {
        Gamemanager.instance.time = 46f;
        Gamemanager.instance.isgameover = false;
        GetComponent<AudioSource>().PlayOneShot(startsound);
        GetComponent<AudioSource>().Play();
        //gameObject.transform.Translate(new Vector3(0f, 0f, 0.7f));

    }

    private void Update()
    {
        if (Gamemanager.instance.isgameover)
        {
            //gameObject.transform.position = new Vector3(0.001f, 0.246f, 2.522f);
            if (endtargetPosition != null)
            {
                transform.position =
                    Vector3.MoveTowards(gameObject.transform.position, endtargetPosition.transform.position, 1f * Time.deltaTime);
            }

        }

        else if (!Gamemanager.instance.isgameover)
        {
            if (starttargetPosition != null)
            {
                transform.position =
                    Vector3.MoveTowards(gameObject.transform.position, starttargetPosition.transform.position, 1f * Time.deltaTime);
            }

            GetComponent<AudioSource>().PlayOneShot(endsound);
        }
    }
}
