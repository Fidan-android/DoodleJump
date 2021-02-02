using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSkin : MonoBehaviour
{
    public Text skin;
    private float updateTime = 2.0f;
    public void Standart()
    {
        GetComponent<AudioSource>().Play();
        Move.index = 0;
        skin.gameObject.SetActive(true);
    }
    private void Update()
    {
        if (updateTime > 0)
        {
            updateTime -= Time.deltaTime;
        } else
        {
            updateTime = 2.0f;
            skin.gameObject.SetActive(false);
        }
    }
}
