using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Settings : MonoBehaviour
{
    private void OnMouseDown()
    {
        GetComponentInParent<AudioSource>().Play();
        SceneManager.LoadScene(2);
    }
}
