using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddBall : MonoBehaviour
{
 public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3) 
        {
            Shooting.amount++;
            Destroy(gameObject);
        }
    }

}
