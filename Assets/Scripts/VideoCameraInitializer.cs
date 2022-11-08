using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoCameraInitializer : MonoBehaviour
{
    
    private bool pickupAllowed;
    // Start is called before the first frame update
    
    private void Update() {
        if(pickupAllowed && Input.GetKeyDown(KeyCode.E)) {
            Interact();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.gameObject.name.Equals("player")) {
            pickupAllowed = true;
        }    
    }

    private void OnTriggerExit2D(Collider2D collision) 
    {
        if (collision.gameObject.name.Equals("player")) {
            pickupAllowed = false;
        }   
    }

    void Interact() 
    {
        Debug.Log("Initialize Director Mode");
    }
}
