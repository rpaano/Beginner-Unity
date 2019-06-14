using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Print();
        Debug.Log(Calculate());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Print()
    {
        Debug.Log("Hello");
    }

    int Calculate()
    {
        int n1 = 2;
        int n2 = 3;

        return n1 + n2;
    }
}
