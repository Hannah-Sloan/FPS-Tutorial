using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class copyCam : MonoBehaviour
{
    [SerializeField] private Camera otherCamera;
    private new Camera camera;

    int cullMask;
    CameraClearFlags cameraClearFlags;


    private void Start()
    {
        camera = GetComponent<Camera>();
        cullMask = camera.cullingMask;
        cameraClearFlags = camera.clearFlags;
    }

    void Update()
    {
        camera.CopyFrom(otherCamera);
        camera.cullingMask = cullMask;
        camera.clearFlags = cameraClearFlags;
    }
}
