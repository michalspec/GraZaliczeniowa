using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMobileControll : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    private float screenWidth;
    void Start()
    {
        screenWidth = Screen.width;
    }
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if(Input.GetTouch(0).position.x > screenWidth /2)
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(Input.GetTouch(0).position.x < screenWidth / 2)
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (rb.position.y < -2f && !FindObjectOfType<GameManager>().isGameEnded)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }

        // Update is called once per frame
        void Update()
    {
        
    }
}
