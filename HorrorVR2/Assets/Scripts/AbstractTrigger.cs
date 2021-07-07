using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum typeEnum
{
    Enter,
    Stay,
    Exit
};
public abstract class AbstractTrigger : MonoBehaviour
{
    [SerializeField] private typeEnum TypeTrigger;
    [SerializeField] private string tag = "Player";

    [Header("Only for Stay")]
    [SerializeField] private float timer = 5;

    private float counter = 0;

    public virtual void Enter() { }
    public virtual void Stay() { }
    public virtual void Exit() { }

    private void stay()
    {
        if (counter < timer)
        {
            counter += Time.fixedDeltaTime;
        }
        else
        {
            counter = 0;
            Stay();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if( other.tag == tag && typeEnum.Enter == TypeTrigger)
            Enter();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == tag && typeEnum.Stay == TypeTrigger)
            stay();
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == tag && typeEnum.Exit == TypeTrigger)
            Exit();
    }
}
