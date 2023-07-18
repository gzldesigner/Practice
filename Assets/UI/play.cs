using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class play : MonoBehaviour

 
{
    // Start is called before the first frame update
    void Start()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Right");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
