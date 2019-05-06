using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Limiter : Singleton<Limiter>
{
    public bool playerIsOutsideTheLimit = false;

    public override void Awake()
    {
        base.Awake();
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsOutsideTheLimit = true;
            Debug.Log("Player are outside the limit");
        }
    }
}
