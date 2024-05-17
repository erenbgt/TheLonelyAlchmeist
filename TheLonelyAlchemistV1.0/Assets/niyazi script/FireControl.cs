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
        // "L" tu�una bas�ld���nda
        if (Input.GetKeyDown(KeyCode.L))
        {
            // Raycast'� atarak etkile�ime ge�en bir nesne var m� kontrol et
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity, HitLayer))
            {
                // E�er Raycast campfire ile temas ettiyse
                if (hit.collider.CompareTag("Fire"))
                {
                    ToggleCampfire(); // Campfire'� a��p kapat
                }
            }
        }
    }

    // Campfire'� a��p kapatan fonksiyon
    void ToggleCampfire()
    {
        isCampfireOn = !isCampfireOn; // Durumu tersine �evir

        // E�er campfire a��ksa
        if (isCampfireOn)
        {
            // Particle System'i etkinle�tir
            campfireParticles.Play();
            campfireParticlesSmoke.Play();
            Debug.Log("Campfire a��ld�!");

            // StartCoroutine(WaitAndStopCampfire());

        }
        else
        {
            // Particle System'i devre d��� b�rak
            campfireParticles.Stop();
            campfireParticlesSmoke.Stop();
            Debug.Log("Campfire kapat�ld�!");
        }


    }
   
}
