using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.5f;
    float speedX, speedY;
   // private int status = 1;
   // private float health = 0.5f;
    public int counter = 0;

    private AudioSource ingameAudioSource;
    [SerializeField] private AudioClip collectSound;

    public Rigidbody2D rb;

    [SerializeField] private TimerScript time;
    [SerializeField] private LogicManager logic;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ingameAudioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        speedX = Input.GetAxisRaw("Horizontal") * speed;
        speedY = Input.GetAxisRaw("Vertical") * speed;
        rb.velocity = new Vector2(speedX, speedY);
    }

    public void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "Collectable")
        {
            time.TimeLeft += 5;//ingameAudioSource.PlayOneShot(collectSound);
            counter++;
            Destroy(other.gameObject);
        }
        else if (other.gameObject.tag == "Finish")
        { 
            logic.nextLevel();
        }
        //{ Debug.Log(other.gameObject.GetType()); }
        //{ //sound
          //destroy object2 ? array?}

    }
}

    // Update is called once per frame
    //void Update()
    //{
    // velocity=speed, velocity vector // gooogle it
    //  Vector3 pos = transform.position;

//if (Input.GetKey(KeyCode.W) | Input.GetKey(KeyCode.UpArrow))
//{
//pos.y += speed * Time.deltaTime;
//  rb.velocity = new Vector3(0, 10, 0);
// }
// if (Input.GetKey(KeyCode.S) | Input.GetKey(KeyCode.DownArrow))
//  {
//    pos.y -= speed * Time.deltaTime;
// }
// if (Input.GetKey(KeyCode.D) | Input.GetKey(KeyCode.RightArrow))
//{
//  pos.x += speed * Time.deltaTime;
// }
//if (Input.GetKey(KeyCode.A) | Input.GetKey(KeyCode.LeftArrow))
//{
//  pos.x -= speed * Time.deltaTime;
//}

// transform.position = pos;
//}