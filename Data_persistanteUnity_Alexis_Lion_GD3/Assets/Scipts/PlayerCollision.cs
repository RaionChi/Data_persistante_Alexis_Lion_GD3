using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        ICollectible Icollect = other.GetComponent<Collectible>();
        if (Icollect != null)
        {
           Icollect.Collect();
        }
  
    }
    private void OnCollisionEnter(Collision collision)
    {
        ITalk talking = collision.gameObject.GetComponent<ITalk>();
        if (talking != null)
        {
            talking.Talk();
        }
    }
}
