using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public float health = 2;
    public AudioSource source { get { return GetComponent<AudioSource>(); } }
    public AudioClip death;

    private void Start()
    {
        gameObject.AddComponent<AudioSource>();
    }

    public void DamageReceived( float damageAmount)
    {
        health -= damageAmount;
        if( health <= 0f)
        {
            Die();
        }
    }

    public void Die()
    {
        source.PlayOneShot(death);
        Destroy(gameObject);
    }
}
