using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changedSkin : MonoBehaviour
{
    public GameObject[] skin;
    void Update()
    {
        for(int i = 0; i < skin.Length; i++)
        {
            if (i == Move.index)
            {
                skin[i].SetActive(true);
            } else
            {
                skin[i].SetActive(false);
            }
        }
    }
}
