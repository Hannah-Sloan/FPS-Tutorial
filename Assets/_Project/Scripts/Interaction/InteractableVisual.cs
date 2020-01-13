using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Works like a tag. Also sets up the hitbox and neccesary actions
/// </summary>
[RequireComponent(typeof(BoxCollider))]
public class InteractableVisual : MonoBehaviour
{
    [SerializeField] private LayerMask normalLayer;
    [SerializeField] private LayerMask lineRenderLayer;

    public void EnableLines()
    {
        gameObject.layer = lineRenderLayer.Layermask_to_layer();
    }

    public void DisableLines()
    {
        gameObject.layer = normalLayer.Layermask_to_layer();
    }
}
