using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerInteract : MonoBehaviour
{

    private Camera cam;
    [SerializeField]
    private float distance = 3f;
    [SerializeField]
    private LayerMask mask;
    private playerUI playerUI;
    private inputManager inputManager;
    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<playerLook>().Camera;   
        playerUI = gameObject.GetComponent<playerUI>();
        inputManager = gameObject.GetComponent<inputManager>();
    }

    // Update is called once per frame
    void Update()
    {
        playerUI.UpdateText(string.Empty);


        Ray ray = new Ray(cam.transform.position, cam.transform.forward);
        Debug.DrawRay(ray.origin, ray.direction * distance);
        RaycastHit hitInfo;

        if (Physics.Raycast(ray, out hitInfo, distance, mask))
        {
            if (hitInfo.collider.GetComponent<interactable>() != null)
            {
                interactable interactable = hitInfo.collider.GetComponent<interactable>();
               // Debug.Log("hit");
                playerUI.UpdateText(interactable.promptMessage);
                if (inputManager.walkingActions.Interact.triggered)
                {
                    interactable.BaseInteract();
                }
            }
        }
    }
}
