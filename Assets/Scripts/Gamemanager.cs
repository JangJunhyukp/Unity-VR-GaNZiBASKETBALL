using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gamemanager : MonoBehaviour
{
    public static Gamemanager instance;
    public bool isgameover = true;
    public int score = 0;
    public float time = 0f;

    public Text timetext;
    public Text scoretext;
    public GameObject FeverUI;
    public AudioClip Feversound;

    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!isgameover)
        {
            GetComponent<AudioSource>().Stop();
            time -= Time.deltaTime;
            timetext.text = (int)time + "";
            scoretext.text = "" + score;
            if ((int)time == 0f)
            {
                isgameover = true;
                //gameover();
            }

            if ((int)time == 15f)
            {
                StartCoroutine("Fever");
            }
        }

        else
        {
            timetext.text = (int)time + "";
            int bestscore = PlayerPrefs.GetInt("BestScore");
            if (score > bestscore)
            {
                bestscore = score;
                PlayerPrefs.SetInt("BestScore", bestscore);
            }

            scoretext.text = "" + bestscore;
        }
    }

    IEnumerator Fever()
    {
        FeverUI.SetActive(true);
        yield return new WaitForSeconds(2f);
        FeverUI.SetActive(false);
    }

    /*void gameover()
    {
        timetext.text = (int)time + "";
        int bestscore = PlayerPrefs.GetInt("BestScore");
        if (score > bestscore)
        {
            bestscore = score;
            PlayerPrefs.SetInt("BestScore", bestscore);
        }

        scoretext.text = "" + bestscore;
    }*/
}
