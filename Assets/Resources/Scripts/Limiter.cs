using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Limiter : MonoBehaviour
{
    bool playerIsOutsideTheLimit = false;

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsOutsideTheLimit = true;
            Debug.Log("Player are outside the limit");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsOutsideTheLimit = false;
            Debug.Log("Player are inside the limit");
        }
    }
}
