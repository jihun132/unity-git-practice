using UnityEngine;

public class Player : MonoBehaviour
{
    float health = 100.0f;
    void TakeDamage(int value)
    {
        health -= value;
        if (health <= 0)
            {
                Die();
            }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void Die()
    {
        Destroy(this.gameObject);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        TakeDamage(20);
        Destroy(collision.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
