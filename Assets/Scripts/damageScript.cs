using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageScript : MonoBehaviour
{
    private Rigidbody rb;
    private int Health = 10;
    private int bulletDamage;
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.tag == "Bullet")
        {
            Health -= other.gameObject.GetComponent<BulletScript>().bulletDamage;
            if (Health < 0)
            {
                Destroy(gameObject);
                //rb.useGravity = true;
            }
        }
        
    }
}
