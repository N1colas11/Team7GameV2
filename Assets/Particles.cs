using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particles : MonoBehaviour
{

    public ParticleSystem clickParticle;
    // Start is called before the first frame update
    public void ParticleThrow()
    {
        clickParticle.Play();
        //Instantiate(particle, transform.position, Quaternion.identity);
    }

}
