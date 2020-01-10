using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColor : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown (KeyCode.Alpha1)) {
		    GetComponent<Renderer>().material.color = new Color(255, 0, 0);
        }
        else if (Input.GetKeyDown (KeyCode.Alpha2)) {
		    GetComponent<Renderer>().material.color = new Color(0, 255, 0);
        }
        else if (Input.GetKeyDown (KeyCode.Alpha3)) {
		    GetComponent<Renderer>().material.color = new Color(0, 0, 255);
        }
    }
}
