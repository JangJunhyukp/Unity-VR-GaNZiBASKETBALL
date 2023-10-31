using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ball : MonoBehaviour
{
    public GameObject goal2Effect;
    public GameObject goal3Effect;
    public AudioClip goal2sound;
    public AudioClip goal3sound;
    
    private void OnTriggerEnter(Collider other)
    {
        if (!Gamemanager.instance.isgameover && other.tag == "net" && Gamemanager.instance.time > 15f)//15f )
        {
            Gamemanager.instance.score += 2;

            Vector3 vector3 = transform.position;
            Instantiate(goal2Effect, vector3, Quaternion.identity);

            GetComponent<AudioSource>().PlayOneShot(goal2sound);
        }

        else if (!Gamemanager.instance.isgameover && other.tag == "net" && Gamemanager.instance.time < 15f)
        {
            Gamemanager.instance.score += 3;

            Vector3 vector3 = transform.position;
            Instantiate(goal3Effect, vector3, Quaternion.identity);

            GetComponent<AudioSource>().PlayOneShot(goal3sound);
        }
    }
}
