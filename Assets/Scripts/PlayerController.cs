using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    public float boostSpeed = 60f;
    private new AudioSource audio;
    // Start is called before the first frame update

    // Update is called once per frame

    private void Start()
    {
        audio = gameObject.GetComponent<AudioSource>();
    }
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if(Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rb.position.y < -2f && !FindObjectOfType<GameManager>().isGameEnded)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

        if(Input.GetKey(KeyCode.Space) && FindObjectOfType<GameManager>().points == 3)
        {
            audio.Play();
            FindObjectOfType<GameManager>().points = 0;
            //FindObjectOfType<GameManager>().points = 0;
            gameObject.GetComponent<PlayerController>().enabled = false;
            Invoke("PlayerBoost", .2f);
        }
    }
    void RegularState()
    {
        gameObject.GetComponent<PlayerController>().enabled = true;
        gameObject.GetComponent<Rigidbody>().useGravity = true;
        gameObject.GetComponent<BoxCollider>().enabled = true;
    }

    void PlayerBoost()
    {
        gameObject.GetComponent<Rigidbody>().useGravity = false;
        gameObject.GetComponent<BoxCollider>().enabled = false;
        rb.velocity = Vector3.forward * boostSpeed;
        Invoke("RegularState", 1.5f);
    }

}
