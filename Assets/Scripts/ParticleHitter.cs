using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleHitter : MonoBehaviour
{
    private void OnParticleCollision(GameObject other)
    {
        if(other.TryGetComponent<IBurnable>(out IBurnable ib))
            ib.OnBurnt(1);
    }
}
