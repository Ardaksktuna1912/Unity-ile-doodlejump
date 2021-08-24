using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yokedici : MonoBehaviour
{
   

   

    void OnTriggerEnter2D(Collider2D col)
    {
        float rastgeleX = Random.Range(-2.26f,2.23f);
        float rastgeleY = 13f;

        if (col.tag == "duvar")
        {
            col.transform.position = new Vector3(rastgeleX, col.transform.position.y + rastgeleY, col.transform.position.z);
           
        }
    }
}
