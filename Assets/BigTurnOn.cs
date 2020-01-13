using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigTurnOn : MonoBehaviour
{
    [SerializeField] private float turnOnTimer;
    [SerializeField] private GameObject video;

    Timer timer;

    void Start()
    {
        timer = Timer.CreateTimer(turnOnTimer);
    }

    private void Update()
    {
        if (timer.CheckComplete())
        {
            video.SetActive(true);
            video.transform.SetParent(null);
            Destroy(gameObject);
        }
    }
}
