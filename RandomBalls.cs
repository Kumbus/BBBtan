using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomBalls : MonoBehaviour
{
    private bool touched = false;

    private void Update()
    {
        if (touched == true && Shooting.moved == false)
            Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            collision.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            collision.GetComponent<Rigidbody2D>().AddForce(SetForce());
            touched = true;
        }
    }

    Vector2 SetForce()
    {
        float forcex = Random.Range(1, 8);
        float forcey = Random.Range(1, 8);

        while (Mathf.Sqrt(forcex * forcex + forcey * forcey) < 65)
        {
            forcey *= 1.3f;
            forcex *= 1.3f;
        }

        return (new Vector2(forcex, forcey));
    }

}
