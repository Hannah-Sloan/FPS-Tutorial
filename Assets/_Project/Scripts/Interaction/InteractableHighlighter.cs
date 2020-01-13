using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableHighlighter : MonoBehaviour
{
    [SerializeField] private Camera mainCam;
    [SerializeField] private float interactLength = 5;

    private InteractableVisual currentInteractableVisual = null;

    void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(mainCam.transform.position, mainCam.transform.forward, out hit, interactLength))
        { 
            Debug.DrawRay(mainCam.transform.position, mainCam.transform.forward * hit.distance, Color.green);
            InteractableVisual interactableVisual = hit.collider.GetComponent<InteractableVisual>();

            if (interactableVisual != null)
                interactableVisual.EnableLines();

            if (currentInteractableVisual != interactableVisual)
            {
                if(currentInteractableVisual != null)
                    currentInteractableVisual.DisableLines();
                currentInteractableVisual = interactableVisual;
            }
        }
        else
        { 
            Debug.DrawRay(mainCam.transform.position, mainCam.transform.forward * interactLength, Color.white);
            if (currentInteractableVisual != null)
            {
                currentInteractableVisual.DisableLines();
                currentInteractableVisual = null;
            }
        }

        if (Input.GetKeyDown(KeyCode.E) && currentInteractableVisual != null)
            ((Interactable)currentInteractableVisual).Interact();
    }

}

