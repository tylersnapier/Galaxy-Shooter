
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private float _enemySpeed = 4f;

    private Player _player;
    private Animator _anim;

    void Start()
    {
        _player = GameObject.Find("Player").GetComponent<Player>();
        //null check player
        if (_player == null )
        {
            Debug.LogError("The Player is NULL");
        }
        //assign the component to anim
        _anim = GetComponent<Animator>();

        if (_anim == null )
        {
            Debug.LogError("The animator is NULL");
        }
    }

    
    void Update()
    {
        transform.Translate(Vector3.down * _enemySpeed * Time.deltaTime);

        if (transform.position.y < -5f)
        {
            float randomX = Random.Range(-8f, 8f);
            transform.position = new Vector3(randomX, 7, 0);
        }
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
       
        if (other.tag == "Player")
        {
            Player player = other.transform.GetComponent<Player>();
            
            if (player != null)
            {
                player.Damage();
            }
            _anim.SetTrigger("OnEnemyDeath");
            _enemySpeed = 0;                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 

            Destroy(this.gameObject, 2.8f); 
        }

        
        if (other.tag == "Laser")
        {
            Destroy(other.gameObject);
            //add 10 to score
            if (_player != null)
            {
                _player.AddScore(10);
            }
            _anim.SetTrigger("OnEnemyDeath");
            _enemySpeed = 0;
            Destroy(this.gameObject, 2.8f);
        }
    }
}
