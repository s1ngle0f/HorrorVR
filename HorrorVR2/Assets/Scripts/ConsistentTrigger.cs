using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsistentTrigger : AbstractTrigger
{
    [Header("Consistent Trigger")]
    [SerializeField] private List<GameObject> nextTriggers;
    [SerializeField] private bool offThisTrigger = true;

    public virtual void Do() { }
    public override void Enter() { doForEvents(); }
    public override void Stay() { doForEvents(); }
    public override void Exit() { doForEvents(); }
    private void doForEvents()
    {
        foreach (GameObject trigger in nextTriggers)
            trigger.SetActive(true);
        Do();
        if (offThisTrigger)
            gameObject.SetActive(false);
    }
}
