using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScaenMove : MonoBehaviour
{
    public string sceneName;
    // Start is called before the first frame update
    public void SceneMove()
    {
        SceneManager.LoadScene(sceneName);
    }
}
