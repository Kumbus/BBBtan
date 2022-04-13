using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Horizontal : MonoBehaviour
{
    [SerializeField]
    private GameObject piuH;

    private bool touched = false;

    private void Update()
    {
        if (touched == true && Shooting.moved == false)
            Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject spawnedPiu;
        if (collision.gameObject.layer == 3)
        {
            spawnedPiu = Instantiate(piuH);
            spawnedPiu.transform.position = transform.position;
            spawnedPiu.GetComponent<Rigidbody2D>().AddForce(new Vector2(40, 0));

            spawnedPiu = Instantiate(piuH);
            spawnedPiu.transform.position = transform.position;
            spawnedPiu.GetComponent<Rigidbody2D>().AddForce(new Vector2(-40, 0));

            touched = true;
        }
    }
}
