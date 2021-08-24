using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zıplama : MonoBehaviour
{
    public float zıplamagücü;
    private Vector2 karakterhizi;
    private Rigidbody2D fizik;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }



     void OnCollisionEnter2D(Collision2D temas)
    {

        if (temas.relativeVelocity.y <= 0) { 
        fizik = temas.collider.GetComponent<Rigidbody2D>();

        if (fizik != null)
        {
            karakterhizi = fizik.velocity;
            karakterhizi.y = zıplamagücü;
            fizik.velocity = karakterhizi;


        }
       }
    }
}
