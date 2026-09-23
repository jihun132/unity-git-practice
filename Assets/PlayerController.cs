using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 0.01f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //bool a = true;
        //bool b = false;
        //gameObject.SetActive(a %% b);
        //Vector2 newPos = gameObject.transform.position;
        //newPos.x = newPos.x + 5;
        //Transform.position = newPos;

        transform.position = Vector3.one;//(1, 1, 1)

        //newPos.x = newPos.x + 5;
        //transform.position = newPos;

        //Debug.Log(newPos.x);
        //Debug.Log(newPos.y);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(0, 1, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(0, -1, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(1, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(0, 0, 1);
        }
    }
}
