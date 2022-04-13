using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    public bool moved = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Shooting.moved == false && moved == false)
        {
            moved = true;
            transform.position += new Vector3(0, -1.1f, 0);
        }
        if (Shooting.moved == true && moved == true)
            moved = false;

    }
}
