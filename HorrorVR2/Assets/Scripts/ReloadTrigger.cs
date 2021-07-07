using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReloadTrigger : AbstractTrigger
{
    [Header("Reload Trigger")]
    [SerializeField] private float reloadTime = 60;//In Seconds

    private float reloadCounter = 0;
    private bool timerActivate;

    public virtual void Do() { }
    public override void Enter() { doForEvents(); }
    public override void Exit() { doForEvents(); }

    private void FixedUpdate()
    {
        if( timerActivate )
        {
            if (reloadCounter < reloadTime)
                reloadCounter += 0.02f;
            else
            {
                timerActivate = false;
                reloadCounter = 0;
            }
        }
    }
    private void doForEvents()
    {
        if (!timerActivate)
            Do();
        timerActivate = true;
    }
}
