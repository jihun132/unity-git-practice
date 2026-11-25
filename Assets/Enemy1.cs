using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class Enemy1 : Enamy
{
    void Start()
    {
        Move();
    }

    void Move()
    {
        GetComponent<Rigidbody2D>().AddForce(Vector2.right * 50);
    }
}
