using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TESTTrigger : ConsistentTrigger
{
    public override void Do()
    {
        Debug.Log("Hello");
        base.Do();
    }
}
