using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityStandardAssets.Vehicles.Aeroplane
{
    public class ExplosionController : Singleton<ExplosionController>
    {
        public ParticleSystem explosion;
        public GameObject gameOver;

        public override void Awake()
        {
            base.Awake();
        }

        void Update()
        {
            if (Limiter.Get().playerIsOutsideTheLimit)
            {
                explosion.Play();
                Limiter.Get().playerIsOutsideTheLimit = false;
                AeroplaneUserControl2Axis.playerIsAlive = false;
                gameOver.SetActive(true);
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                UIGameplayManager.Get().gameOver = true;
            }
        }
    }
}
