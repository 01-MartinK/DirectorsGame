using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagementInitializer : MonoBehaviour
{
    public GameObject managementScreen;
    private bool pickupAllowed;
    private bool inUse;
    // Start is called before the first frame update
    
    private GameObject player;

    private void Start() {
        player = UnityEngine.GameObject.FindGameObjectWithTag("Player");
    }

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
    // Start is called before the first frame update
    void Interact() 
    {
        if (inUse){ 
            inUse = false;
            managementScreen.SetActive(false); 
            player.GetComponent<playerController>().canControl = true;
        }
        else{
            managementScreen.SetActive(true); 
            inUse = true;
            player.GetComponent<playerController>().canControl = false;
        }

        Debug.Log("Initialize Management Mode");
    }
}
