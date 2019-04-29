using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JetController : MonoBehaviour
{
    public float EnginePower = 50f;
    float RollEffect = 1f;
    float PitchEffect = 1f;
    float YawEffect = 0.2f;
    float mouseX = 0f;
    float mouseY = 0f;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce(transform.forward * EnginePower * Time.deltaTime);
        }
        transform.Rotate(new Vector3(-Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), Input.GetAxis("Horizontal")) * Time.deltaTime * EnginePower);
    }

}
