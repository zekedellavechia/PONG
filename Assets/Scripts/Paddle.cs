using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed;
    public float minY;
    public float maxY;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //ver si somos derecha o izquierda

        if(gameObject.name=="RightPlayer")
        {
            MovePaddle(gameObject.name);

        }   
        
        else if(gameObject.name=="LeftPlayer")
        {
            MovePaddle(gameObject.name);
        }    

        //mover el objeto
        
    }//update



    void MovePaddle(string paddleName)
    {
        float moveY = Input.GetAxisRaw(paddleName) * speed * Time.deltaTime;
        transform.position = new Vector2(
         transform.position.x,
         Mathf.Clamp(transform.position.y + moveY, minY, maxY));
    }    
}//class
