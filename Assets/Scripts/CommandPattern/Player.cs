using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<InteractableBase>() != null)
        {
            InteractableBase interactableBase = other.GetComponent<InteractableBase>();

            interactableBase.interract();
        }
    }
}
