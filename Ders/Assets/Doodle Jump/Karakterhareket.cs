using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Karakterhareket : MonoBehaviour
{

    public float hiz;
    public Rigidbody2D doodle;
    private float hareketInput;
    
    
    void Start()
    {
        
    }

   
    void Update()
    {
        hareketInput = Input.GetAxis("Horizontal");
        doodle.velocity = new Vector2(hiz * hareketInput, doodle.velocity.y);
    }

     void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "bitis")
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }
    }
}
