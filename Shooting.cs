using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    public static bool moved = false;
    public static Vector3 mousepos;

    public static int numberOfBalls = 0;

    public Rigidbody2D rg2d;
    public static int amount = 1;
    public static int amountOfBalls = 1;


    // Start is called before the first frame update
    void Start()
    {
        rg2d = GetComponent<Rigidbody2D>();

    }
    private void Update()
    {
        
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("DownCollider"))
        {
            Destroy(gameObject);
            numberOfBalls--;
            if (numberOfBalls == 0)
            {
                Score.score++;
                moved = false;
                SpawningObjects.spawned = false;
                amountOfBalls = amount;
                
            }
        }
    }




}
