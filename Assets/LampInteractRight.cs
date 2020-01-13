using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class LampInteractRight : LampInteract
{
    [SerializeField] private RigidbodyFirstPersonController player;
    [SerializeField] private GameObject prompt;

    public override void Interact()
    {
        base.Interact();
        player.mouseLook.rightOnly = false;
        player.mouseLook.MinimumY = -97f;
        prompt.SetActive(true);
    }
}
