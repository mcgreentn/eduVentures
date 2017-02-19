using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Play_Again : MonoBehaviour
{

    // Use this for initialization
    void Restart() {
        SceneManager.LoadScene("Main Menu");
    }
}
