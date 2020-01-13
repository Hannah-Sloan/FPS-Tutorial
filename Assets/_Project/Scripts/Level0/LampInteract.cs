using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampInteract : Interactable
{
    [SerializeField] private Color baseEmmisionColor;
    [SerializeField] private float onEmit;
    [SerializeField] private float offEmit;
    [SerializeField] private new Light light;

    new Renderer renderer;
    Material mat;
    Color baseColor;

    private bool on = false;

    public void Start()
    {
        renderer = GetComponent<Renderer>();
        mat = renderer.material;
        baseColor = baseEmmisionColor;
    }

    [ContextMenu("Interact")]
    public override void Interact()
    {
        on = !on;
        SetEmmision(on ? onEmit : offEmit);
        light.enabled = on;
    }

    public void SetEmmision(float value)
    {
        float emission = value;
        Color finalColor = baseColor * emission; 
        mat.SetColor("_EmissionColor", finalColor);
    }
}
