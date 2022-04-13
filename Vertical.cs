using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vertical : MonoBehaviour
{
    [SerializeField]
    private GameObject piuV;

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
            spawnedPiu = Instantiate(piuV);
            spawnedPiu.transform.position = transform.position;
            spawnedPiu.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 40));

            spawnedPiu = Instantiate(piuV);
            spawnedPiu.transform.position = transform.position;
            spawnedPiu.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -40));

            touched = true;
        }
    }
}
