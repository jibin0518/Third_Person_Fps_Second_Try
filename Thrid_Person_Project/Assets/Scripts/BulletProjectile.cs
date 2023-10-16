using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletProjectile : MonoBehaviour
{
    private Rigidbody bulletRigid;

    private void Awake()
    {
        bulletRigid = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        float spd = 10f;
        bulletRigid.velocity = transform.forward * spd;
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
