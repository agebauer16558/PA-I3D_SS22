using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SitDown : InteractableObject
{
    public Vector3 savePlayerPosition;
    public Vector3 savePlayerRotation;

    public Transform teleportPosition;
    public Transform playerPosition;

    private bool isTeleported;
    private GameObject player;
    private CharacterController movement;
    
    // Start is called before the first frame update
    void Start()
    {
        playerPosition = null;
        isTeleported = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isTeleported && Input.GetKeyDown(KeyCode.E))
        {
            print(savePlayerPosition);
            player.transform.position = savePlayerPosition;
            player.transform.eulerAngles = savePlayerRotation;

            movement.enabled = true;
            isTeleported = false;
        }

        print(isTeleported);
    }

    public override void TriggerInteraction()
    {
        if (!isTeleported) 
        {
            print("hallo");
            TeleportPlayer(); 
        }
    }

    private void TeleportPlayer()
    {
        // Finds The Object for the Player in Scene 
        player = GameObject.FindGameObjectWithTag("Player");

        // Disables Character Controller so Playe gets teleported
        movement = player.gameObject.GetComponent<CharacterController>();

        // Saves position before teleporting
        savePlayerPosition = player.transform.position;
        savePlayerRotation = player.transform.eulerAngles;
                      
        movement.enabled = false;

        // Teleports the player to the given point
        player.transform.position = teleportPosition.position;
        player.transform.rotation = teleportPosition.rotation;

        isTeleported = true;
        print(savePlayerPosition);
    }
}
