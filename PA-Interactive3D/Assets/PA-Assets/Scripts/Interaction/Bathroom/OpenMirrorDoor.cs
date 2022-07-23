using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenMirrorDoor : InteractableObject
{
    public Animator openMirrorDoor;

    public bool currentStateMirrorDoor;

    public override void TriggerInteraction()
    {
        currentStateMirrorDoor = openMirrorDoor.GetBool("mirrorOpened");
        openMirrorDoor.SetBool("mirrorOpened", !currentStateMirrorDoor);
    }

    void Update()
    {
 
    }

}