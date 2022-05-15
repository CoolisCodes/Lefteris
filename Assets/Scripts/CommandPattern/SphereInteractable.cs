using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereInteractable : InteractableBase
{
    public override void interract()
    {
        GetComponent<Transform>().position = new Vector3(0, GetComponent<Transform>().position.y + 2, 0);
    }
}
