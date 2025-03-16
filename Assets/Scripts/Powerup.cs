using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{
    [SerializeField]
    private float _speed = 3f;
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Translate(Vector3.down * _speed * Time.deltaTime);

        if (transform.position.y < -4.5f)
        {
            Destroy(this.gameObject);
        }
        //move down at speed of 3 (adjust in the Inspector)
        //Destroy object when leaves screen
       
    }

     void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            //Communicate with the Player script
            //handle the component I want
            //assign the handle to the component
            Player player = other.transform.GetComponent<Player>();

            if (player != null)
            {
                player.TripleShotActive();
            }


            Destroy(this.gameObject);
        }
    }
    //OnTriggerCollision
    //Only be collected by the Player (HINT: Use Tags)
    //On collected, Destroy
}
