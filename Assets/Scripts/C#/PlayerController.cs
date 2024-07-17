using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.5f;
    public float health = 5f;
    float speedX, speedY;
    public int counter = 0;

    private AudioSource ingameAudioSource;
    [SerializeField] private AudioClip collectSound;
    [SerializeField] private AudioClip portalSound;
    bool facingRight = true;

    public Rigidbody2D rb;

    [SerializeField] private TimerScript time;
    [SerializeField] private LogicManager logic;

    [SerializeField] private TimerScript timer;

    public GameObject gameFailScreen;
    public string toMenu;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ingameAudioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (timer.TimerOn == true)
        {
            speedX = Input.GetAxisRaw("Horizontal");
            speedY = Input.GetAxisRaw("Vertical");

            rb.velocity = new Vector2(speedX * speed, speedY * speed);

            if (speedX > 0 && !facingRight)
            {
                Flip();
            }
            else if (speedX < 0 && facingRight)
            {
                Flip();
            }
        }
        else
        {
            gameFailScreen.SetActive(true);
        }

        if (Input.GetKey("escape"))
        {
            SceneManager.LoadScene(toMenu);
        }
    }

    void Flip()
    {
        Vector3 currentScale = gameObject.transform.localScale;
        currentScale.x *= -1;
        gameObject.transform.localScale = currentScale;

        facingRight = !facingRight;
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Collectable")
        {
            time.TimeLeft += 5;
            ingameAudioSource.PlayOneShot(collectSound);
            counter++;
            Destroy(other.gameObject);
        }
        else if (other.gameObject.tag == "Finish")
        { 
            logic.nextLevel();
            ingameAudioSource.PlayOneShot(portalSound);
        }

    }
}