using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDrawers : InteractableObject
{
    public Animator openTopDrawer;

    public Animator openBottomDrawer;

    private bool currentStateDrawer;

    public override void TriggerInteraction()
    {
        currentStateDrawer = openTopDrawer.GetBool("drawerOpened");
        openTopDrawer.SetBool("drawerOpened", !currentStateDrawer);

        currentStateDrawer = openBottomDrawer.GetBool("drawerOpened");
        openBottomDrawer.SetBool("drawerOpened", !currentStateDrawer);
    }
}
