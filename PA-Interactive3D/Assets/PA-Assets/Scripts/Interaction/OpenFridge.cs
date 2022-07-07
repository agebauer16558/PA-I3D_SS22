using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenFridge : InteractableObject
{
    public Animator moveFridge;

    private bool currentState;

    public override void TriggerInteraction()
    {
        currentState = moveFridge.GetBool("fridgeOpened");
        moveFridge.SetBool("fridgeOpened", !currentState);
    }
}
