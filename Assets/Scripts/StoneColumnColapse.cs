using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneColumnColapse : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    public Transform column;
    public Rigidbody rb;
    public float distance = 50f;
    private bool flag = true;
    public bool LeftFall = true;
  
    private void FixedUpdate()
    {
        if(column.position.z - player.position.z < distance && flag ==true && LeftFall)
        {
            rb.freezeRotation = false;
            column.Rotate(0,0, 3,Space.World);
            flag = false;
        }
        if (column.position.z - player.position.z < distance && flag == true && !LeftFall)
        {
            rb.freezeRotation = false;
            column.Rotate(0, 0, -3, Space.World);
            flag = false;
        }
    }
}
