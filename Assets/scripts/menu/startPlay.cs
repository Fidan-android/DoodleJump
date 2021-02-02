using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class startPlay : MonoBehaviour
{
    private void OnMouseDown()
    {
        GetComponentInParent<AudioSource>().Play();
        SceneManager.LoadScene(1);
    }

}
