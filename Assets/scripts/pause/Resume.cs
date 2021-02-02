using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resume : MonoBehaviour
{
    public GameObject rg;
    public GameObject menu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            rg.GetComponent<Rigidbody2D>().gravityScale = 0.8f;
            menu.gameObject.SetActive(false);
        }
    }
    public void ClickText()
    {
        rg.GetComponent<Rigidbody2D>().gravityScale = 0.8f;
        menu.gameObject.SetActive(false);
    }
}
