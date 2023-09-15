using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public float forwardforce=2000f;
    public float sidewaysforce=500f;
    public float upperforce=2000f;
    public Rigidbody rb;
    // Start is called before the first frame update
    // void Start()
    // {
    //     Debug.Log("SSSupp!");
       
    //     rb.AddForce(0,500,500);
    // }

    // Update is called once per frame
    void FixedUpdate()
    {
         rb.AddForce(0,0,forwardforce* Time.deltaTime);
         if (Input.GetKey("d"))
         {
            rb.AddForce(sidewaysforce*Time.deltaTime,0,0,ForceMode.VelocityChange);
         }
          if (Input.GetKey("a"))
         {
            rb.AddForce(-sidewaysforce*Time.deltaTime,0,0,ForceMode.VelocityChange);
         }
          if (Input.GetKey("s"))
         {
            rb.AddForce(0,-upperforce*Time.deltaTime,0);
         }
         if (Input.GetKey("w"))
         {
            rb.AddForce(0,upperforce*Time.deltaTime,0);
         }
          if (Input.GetKey("x"))
         {
            rb.AddForce(0,0,-3000*Time.deltaTime);
         }
         if (rb.position.y < -1f)
         {
            FindObjectOfType<GameManager>().EndGame();
         }
    }
}
