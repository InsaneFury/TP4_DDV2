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

        private void Awake()
        {
            Cursor.lockState = CursorLockMode.Locked;
            // Set up the reference to the aeroplane controller.
            m_Aeroplane = GetComponent<AeroplaneController>();
        }

        private void FixedUpdate()
        {
            // Read input for the pitch, yaw, roll and throttle of the aeroplane.
            float roll = Input.GetAxis("Mouse X");
            float pitch = Input.GetAxis("Mouse Y");
            float yaw = Input.GetAxis("Horizontal");
            bool airBrakes = Input.GetButton("Fire1");

            // auto throttle up, or down if braking.
            float throttle = airBrakes ? -1 : 1;

            // Pass the input to the aeroplane
            m_Aeroplane.Move(roll, pitch, yaw, throttle, airBrakes);
        }
    }
}
