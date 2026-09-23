using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    char a = 'a';
    string b = "abc";
    bool c = true;
    bool d = false;
    object e = 1;
    object f = 0.1;
    object g = "Hello";
    object h = true;

    int num1 = 10;
    double num2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        num2 = (double)num1;
        Debug.Log(num1);
        Debug.Log(num2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
