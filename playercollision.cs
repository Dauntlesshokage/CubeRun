using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercollision : MonoBehaviour
{
    // Start is called before the first frame update
    public playermovement movement;
   
    void OnCollisionEnter(Collision collisioninfo)
    {
        if (collisioninfo.collider.tag=="Obstacle")
        {
            movement.enabled=false;
            FindObjectOfType<GameManager>().EndGame();

        }
    }
}
