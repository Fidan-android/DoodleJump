using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundOnOff : MonoBehaviour
{
    public Sprite[] sprites;
    public GameObject sound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        if (GetComponent<SpriteRenderer>().sprite == sprites[0])
        {
            GetComponent<SpriteRenderer>().sprite = sprites[1];
            sound.GetComponent<AudioSource>().Stop();
        }
        else if (GetComponent<SpriteRenderer>().sprite == sprites[1])
        {
            GetComponent<SpriteRenderer>().sprite = sprites[0];
            sound.GetComponent<AudioSource>().Play();
        }
    }
}
