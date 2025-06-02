using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    [SerializeField]
    private float _rotationSpeed = 3.0f;

    [SerializeField]
    private GameObject _explosionPrefab;
    
    void Start()
    {
        
    }

   
    void Update()
    {
        //rotate on zed axis
        transform.Rotate(Vector3.forward * _rotationSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //check if the collider is a laser
        if (other.tag == "Laser")
        {
            Instantiate(_explosionPrefab, transform.position, Quaternion.identity);
            Destroy(other.gameObject); //destroy the laser  
            Destroy(this.gameObject, 0.25f); //destroy the asteroid
        }
    }
    //check for laser collission (TRIGGER)
    //instantiate explosion at the position of the asteroid
    //destroy explosion after 3 seconds
}
