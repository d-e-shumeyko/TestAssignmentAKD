using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class interactable : MonoBehaviour
{
    public bool useEvents;
    [SerializeField]
    public string promptMessage;

    public void BaseInteract()
    {
        if (useEvents)
        {
            GetComponent<interactionEvents>().onInteract.Invoke();
        }
        Interact();
    }
  protected virtual void Interact()
    {

    }
}
