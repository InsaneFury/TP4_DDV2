using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityStandardAssets.Vehicles.Aeroplane
{
    public class ExplosionController : Singleton<ExplosionController>
    {
        public Limiter limit;
        public ParticleSystem explosion;

        public override void Awake()
        {
            base.Awake();
        }

        void Update()
        {
            if (limit.playerIsOutsideTheLimit)
            {
                explosion.Play();
                limit.playerIsOutsideTheLimit = false;
                AeroplaneUserControl2Axis.playerIsAlive = false;
            }
        }
    }
}
