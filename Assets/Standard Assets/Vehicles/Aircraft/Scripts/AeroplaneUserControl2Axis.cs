using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets.Vehicles.Aeroplane
{
    [RequireComponent(typeof(AeroplaneController))]
    public class AeroplaneUserControl2Axis : MonoBehaviour
    {
        // reference to the aeroplane that we're controlling
        private AeroplaneController m_Aeroplane;
        public static bool playerIsAlive = true;
        public GameObject explosion;
        public GameObject gameOver;

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.collider.CompareTag("aro") || collision.collider.CompareTag("environment"))
            {
                playerIsAlive = false;
                explosion.SetActive(true);
                gameOver.SetActive(true);
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
        }

        private void Awake()
        {
            Cursor.lockState = CursorLockMode.Locked;
            playerIsAlive = true;
            // Set up the reference to the aeroplane controller.
            m_Aeroplane = GetComponent<AeroplaneController>();
        }

        private void FixedUpdate()
        {
            // Read input for the pitch, yaw, roll and throttle of the aeroplane.
            float roll = Input.GetAxis("Mouse X");
            float pitch = Input.GetAxis("Mouse Y");
            float yaw = Input.GetAxis("Horizontal");
            bool airBrakes = Input.GetButton("Fire2");

            // auto throttle up, or down if braking.
            float throttle = airBrakes ? -1 : 1;

            // Pass the input to the aeroplane
            if (playerIsAlive)
            {
                m_Aeroplane.Move(roll, pitch, yaw, throttle, airBrakes);
            }
            else
            {
                m_Aeroplane.Move(0, 0, 0, -1, true);
            }
           
        }
    }
}
