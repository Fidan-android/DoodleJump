using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class rating : MonoBehaviour
{
    public static string path = @"Resources\rating.txt";
    public static bool existsPatgh = false;
    private void OnMouseDown()
    {
        GetComponentInParent<AudioSource>().Play();
        SceneManager.LoadScene(3);
    }
}
