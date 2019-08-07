using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LastRing : MonoBehaviour
{
    public GameObject win;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            win.SetActive(true);
            Invoke("GoToMenu", 3);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }

    void GoToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
