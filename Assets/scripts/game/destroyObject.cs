using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyObject : MonoBehaviour
{

    public GameObject player;
    public GameObject[] Prefabs;
    private GameObject myPlat;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        myPlat = Instantiate(Prefabs[Random.Range(0, 7)], new Vector2(Random.Range(-2.4f, 2.4f), collision.transform.position.y + 7.5f), Quaternion.identity);
        Destroy(collision.gameObject);
    }
}
