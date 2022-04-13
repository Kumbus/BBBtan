using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningBalls : MonoBehaviour
{

    [SerializeField]
    private GameObject firstBall;
    GameObject spawnedBall;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Shooting.moved == false && Input.GetMouseButtonDown(0))
        {
            Shooting.moved = true;
            Shooting.mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Shooting.mousepos.y = Shooting.mousepos.y - transform.position.y;
            StartCoroutine(SpawnBalls()); 
        }

    }
    IEnumerator SpawnBalls()
    {
        for (int i = 0; i < Shooting.amountOfBalls; i++)
        {
            yield return new WaitForSeconds(0.1f);
            spawnedBall = Instantiate(firstBall);
            Shooting.numberOfBalls++;
            spawnedBall.transform.position = transform.position;
            SetForce();
            spawnedBall.GetComponent<Rigidbody2D>().AddForce(new Vector2(Shooting.mousepos.x, Shooting.mousepos.y));
        }
    }

    void SetForce()
    {
        float forcex = Shooting.mousepos.x;
        float forcey = Shooting.mousepos.y;
       
        while(Mathf.Sqrt(forcex*forcex+forcey*forcey)<65)
        {
            forcey *= 1.3f;
            forcex *= 1.3f;
        }
        Shooting.mousepos.x = forcex;
        Shooting.mousepos.y = forcey;
    }
}
