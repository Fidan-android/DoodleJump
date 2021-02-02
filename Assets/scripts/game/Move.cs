using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class Move : MonoBehaviour
{
    public Rigidbody2D rg;
    const float speed = 5f;
    const float jump = 10f;
    private SpriteRenderer sprite;
    public Collider2D destroy;
    public Text score;
    private int scoreInt = 0;
    public static float gravityForce;
    private bool isStarted = false, lose = false;
    public Text startText;
    private float coordY;
    private bool firstStep = false;
    public Text loseText;
    public GameObject restart, home;
    public static int index = 0;
    public Sprite[] spriteRenderers;
    public GameObject menu;
    public GameObject loseMenu;
    public static Vector2 pauseVelocity;
    public static string results;

    private void Start()
    {
        GetComponent<SpriteRenderer>().sprite = spriteRenderers[index];
        sprite = GetComponent<SpriteRenderer>();
        destroy = GetComponent<Collider2D>();
        rg = GetComponent<Rigidbody2D>();
        gravityForce = rg.gravityScale;
        rg.gravityScale = 0;
        pauseVelocity = rg.velocity;
        rg.velocity = Vector3.zero;
        coordY = Mathf.Round(rg.transform.position.y);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.StartsWith("GreenStep"))
        {
            Physics2D.IgnoreCollision(destroy, GetComponent<Collider2D>());
            rg.velocity = new Vector2(0, 0);
            rg.AddForce(Vector2.up * jump, ForceMode2D.Impulse);
            if (Mathf.Round(rg.transform.position.y) > coordY)
            {
                scoreInt++;
            }
            coordY = Mathf.Round(rg.transform.position.y);
            firstStep = true;
        }
        else if (collision.gameObject.name.StartsWith("YellowStep"))
        {
            Physics2D.IgnoreCollision(destroy, GetComponent<Collider2D>());
            rg.velocity = new Vector2(0, 0);
            rg.AddForce(Vector2.up * 15f, ForceMode2D.Impulse);
            
            firstStep = true;
        }
        if (Mathf.Round(rg.transform.position.y) > coordY)
        {
            scoreInt++;
        }
        coordY = Mathf.Round(rg.transform.position.y);
    }
    private void FixedUpdate()
    {
        if (isStarted)
        {
            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(Vector2.left * speed * Time.deltaTime);
                sprite.flipX = false;
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(Vector2.right * speed * Time.deltaTime);
                sprite.flipX = true;
            }
            if (rg.transform.position.y < coordY-2 && firstStep)
            {
                GetComponent<AudioSource>().Stop();
            }
            if (rg.transform.position.y < coordY-5)
            {
                lose = true;
                rg.gravityScale = 0;
                rg.velocity = Vector3.zero;
            }
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && isStarted)
        {
            gravityForce = rg.gravityScale;
            print(gravityForce);
            rg.gravityScale = 0;
            rg.velocity = Vector3.zero;
            menu.gameObject.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Space) && !isStarted)
        {
            isStarted = true;
            startText.gameObject.SetActive(false);
            rg.gravityScale = gravityForce;
        }

        if (isStarted)
        {
            score.text = "Score: " + Mathf.Round(scoreInt).ToString();
        }
        if (lose)
        {
            playerLose();
            results = scoreInt.ToString();
        }
    }

    void playerLose()
    {
        loseMenu.SetActive(true);
    }
}
