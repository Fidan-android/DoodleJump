using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class ConfirmOk : MonoBehaviour
{
    public GameObject confirm;
    public static bool del = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickOn()
    {
        del = true;
        File.Delete(rating.path);
        confirm.SetActive(false);
        File.Create(rating.path);
    }
}
