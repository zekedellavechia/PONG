using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    //para editar la velocidad
    public float speed;

    //darle direcicion x e y
    Vector2 direction;

    Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        //referencia al Rigid
        rb = GetComponent<Rigidbody2D>();

        //que la direccion sea igual al vector2 (o sea 1,1 y normalizar el vector)
        direction = Vector2.one.normalized;
        
    }

    private void FixedUpdate()
    {

        rb.velocity = direction * speed;

        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            direction.y = -direction.y;
        }
        else if(collision.gameObject.CompareTag("Paddle"))
        {
            speed += Random.Range(0.5f, 1.5f);
            direction.x = -direction.x;

        }    
    }

}
