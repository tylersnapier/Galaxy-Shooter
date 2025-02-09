using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private float _enemySpeed = 4f;
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Translate(Vector3.down * _enemySpeed * Time.deltaTime);

        if (transform.position.y < -5f)
        {
            float randomX = Random.Range(-8f, 8f);
            transform.position = new Vector3(randomX, 7, 0);
        }
        //move down at 4 meters per second
        //if at bottom of screen
        //respawn at top (with new random X pos
    }

    private void OnTriggerEnter(Collider other)
    {
        //if other is player
        //Damage the player
        //Destroy enemy
        if (other.tag == "Player")
        {
            Destroy(this.gameObject);
        }

        //if other is laser
        //Destroy laser
        //Destroy enemy
        if (other.tag == "Laser")
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}
