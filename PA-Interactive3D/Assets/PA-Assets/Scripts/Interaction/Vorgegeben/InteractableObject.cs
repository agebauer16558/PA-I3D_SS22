using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InteractableObject : MonoBehaviour
{
    public string commandText; 

    public abstract void TriggerInteraction();

}
