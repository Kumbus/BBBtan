using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiuPiu : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 8)
        {
            collision.GetComponent<Life>().life--;
        }
        else if(collision.gameObject.layer == 7)
        {
            Debug.Log("jej");
            Destroy(gameObject);
            Debug.Log("jej2");
        }
    }

}
