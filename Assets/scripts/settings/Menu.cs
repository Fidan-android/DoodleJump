using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void goMenu()
    {
        GetComponent<AudioSource>().Play();
        SceneManager.LoadScene(0);
    }
}
