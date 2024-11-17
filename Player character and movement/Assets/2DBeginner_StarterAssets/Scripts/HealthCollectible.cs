using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectible : MonoBehaviour
{
public GameObject HealthPickUp;

void OnTriggerEnter2D(Collider2D other)
{
   PlayerController controller = other.GetComponent<PlayerController>();


   if (controller != null && controller.health< controller.maxHealth)
   {
    
   controller.ChangeHealth(1);
   Instantiate(HealthPickUp, transform.position, transform.rotation);
   // ParticleSystem particleSystem = HealthPickUp.GetComponent<ParticleSystem();
   // particleSystem.Start();
   Destroy(gameObject);
   }

}
}