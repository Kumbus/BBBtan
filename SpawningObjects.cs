using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningObjects : MonoBehaviour
{
    [SerializeField]
    GameObject[] objectsReference;

    int additionalBallPosition;
    public static bool spawned = false;

    // Update is called once per frame
    void LateUpdate()
    {
        if (Shooting.moved == false && spawned == false)
        {
            spawned = true;
            Spawn();
            
        }
    }

    void Spawn()
    {
        
        GameObject spawnedObject;
        additionalBallPosition = Random.Range(0, 6);
        spawnedObject = Instantiate(objectsReference[0]);
        spawnedObject.transform.position = new Vector2((float)(1.1 * additionalBallPosition - 3.3), 9.3f);

        for (int i = 0; i < 7; i++) 
        {
            
            if (i != additionalBallPosition) 
            {
                spawnedObject = Instantiate(Draw());
                spawnedObject.transform.position = new Vector2((float)(1.1 * i - 3.3), 9.3f);
            }
        }
        //tabela game objectów z 7 miejscami i do ka¿dego dajemy coœ wylosowanego z puli
    }

    GameObject Draw()
    {
        int position = Random.Range(1, 100);

        if (position < 35)
            return objectsReference[1];
        else if(position<40)
            return objectsReference[2];
        else if (position < 40)
            return objectsReference[3];
        else if (position < 45)
            return objectsReference[4];
        else if (position < 50)
            return objectsReference[5];
        else if (position < 55)
            return objectsReference[6];
        else if (position < 60)
            return objectsReference[7];
        else if (position < 65)
            return objectsReference[8];
        else
            return objectsReference[9];
    }
}
