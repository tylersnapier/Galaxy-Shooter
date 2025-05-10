﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{
    [SerializeField]
    private float _speed = 3f;

    [SerializeField] //0 = TripleShot 1 = Speed 2 = Shields
    private int _powerupID;
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
        
       
    }

     void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            
            Player player = other.transform.GetComponent<Player>();

            if (_powerupID == 0)
            {
                
                player.TripleShotActive();
                //else if _powerupID is 1
                //play speed powerup
                //else if _powerupID is 2
                //play shields powerup 
            }

            else if (_powerupID == 1)
            {
                Debug.Log("Speed boost collected");
            }

            else if (_powerupID == 2)
            {
                Debug.Log("Shields collected");
            }


            Destroy(this.gameObject);
        }
    }
    
}
