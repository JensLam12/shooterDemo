using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponFire : MonoBehaviour
{
    public float damage = 1f;
    public float range = 150f;
    public Camera playercam;
    public AudioSource source { get { return GetComponent<AudioSource>(); } }
    public AudioClip audioClip;
    // Start is called before the first frame update
    void Start() {
        gameObject.AddComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if( Input.GetButtonDown("Fire1"))
        {
            shoot();
        }
    }

    void shoot()
    {
        RaycastHit hit;
        if( Physics.Raycast(playercam.transform.position, playercam.transform.forward, out hit, range) )
        {
            source.PlayOneShot(audioClip);
            Target target = hit.transform.GetComponent<Target>();
            if( target != null)
            {
                target.DamageReceived(damage);
            }
        }
    }
}
