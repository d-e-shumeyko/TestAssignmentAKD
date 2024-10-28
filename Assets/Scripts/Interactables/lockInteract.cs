using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lockInteract : interactable
{
    [SerializeField]
    private GameObject door;
    private bool doorOpen;
    [SerializeField]
    private GameObject key;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected override void Interact()
    {

     doorOpen = !doorOpen;
        door.GetComponent<Animator>().SetBool("isopen", doorOpen);
        key.SetActive(false);
    }
}
