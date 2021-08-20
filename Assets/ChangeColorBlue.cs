using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorBlue : MonoBehaviour {
 void OnCollisionEnter(Collision other) {

        if (other.gameObject.tag == "Bar") { 
        
            GetComponent<Renderer>().material.color = Color.blue;
        }
        if (other.gameObject.tag == "Bar")
        {

            GetComponent<Renderer>().material.color = Color.green;
        }
    }

}

