using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireControl : MonoBehaviour
{
    public ParticleSystem campfireParticles; // Campfire'�n Particle System bile�eni
    public ParticleSystem campfireParticlesSmoke;
    public LayerMask HitLayer; // Raycast'�n etkile�ime ge�ece�i layer

    private bool isCampfireOn = true; // Campfire'�n a��k/kapal� durumu

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity, HitLayer))
            {
                if (hit.collider.CompareTag("Fire"))
                {
                    ToggleCampfire(); // Campfire'� a��p kapat
                }
            }
        }
    }

    void ToggleCampfire()
    {
        isCampfireOn = !isCampfireOn; 

        if (isCampfireOn)
        {
            campfireParticles.Play();
            campfireParticlesSmoke.Play();
            Debug.Log("Campfire a��ld�!");

            // StartCoroutine(WaitAndStopCampfire());

        }
        else
        {
            campfireParticles.Stop();
            campfireParticlesSmoke.Stop();
            Debug.Log("Campfire kapat�ld�!");
        }


    }
   
}
