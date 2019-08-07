using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AroTrigger : MonoBehaviour
{
    public GameObject aro;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            aro.SetActive(false);
        }
    }
}
