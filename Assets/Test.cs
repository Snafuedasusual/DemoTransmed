using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        

        for (int i = 0; i < 10; i++)
        {
            Debug.Log(Random.Range(0,10));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
