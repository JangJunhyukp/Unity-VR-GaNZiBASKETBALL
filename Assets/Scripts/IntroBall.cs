using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class IntroBall : MonoBehaviour
{
    public AudioClip goalsound;
    public GameObject goaleffect;
    public string scenename;
    public GameObject hideui;
    public GameObject showui;
    // Start is called before the first frame update
    private void Sceneload()
    {
        SceneManager.LoadScene(scenename);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "net")
        {
            GetComponent<AudioSource>().PlayOneShot(goalsound);
            hideui.SetActive(false);
            showui.SetActive(true);
            Instantiate(goaleffect, transform.position, Quaternion.identity);
            Invoke("Sceneload", 3f);
        }
    }
}
