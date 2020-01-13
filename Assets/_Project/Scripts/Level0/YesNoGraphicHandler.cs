using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YesNoGraphicHandler : MonoBehaviour
{
    [SerializeField] private GameObject yesGraphic;
    [SerializeField] private GameObject noGraphic;

    bool yes = true;

    [SerializeField] private float yesTime;
    [SerializeField] private float noTime;

    Timer yesTimer;
    Timer noTimer;


    void Start()
    {
        yesTimer = Timer.CreateTimer(yesTime);
        noTimer = Timer.CreateTimer(noTime);
    }

    void Update()
    {
        TimerUpdate();
        GraphicUpdate();
    }

    void TimerUpdate()
    {
        Timer runTimer = yes ? yesTimer : noTimer;
        Timer waitTimer = yes ? noTimer : yesTimer;

        if (runTimer.CheckComplete())
        {
            waitTimer.ResetTimer();
            waitTimer.Play();
            yes = !yes;
        }
    }

    void GraphicUpdate()
    {
        yesGraphic.SetActive(yes);
        noGraphic.SetActive(!yes);
    }
}
