using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damageScript : MonoBehaviour
{
    private Rigidbody rb;
    private int health = 10;
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
            health -= other.gameObject.GetComponent<BulletScript>().bulletDamage;
            if (health < 0)
            {
                Destroy(gameObject);
                /*rb.useGravity = true;
                rb.constraints = RigidbodyConstraints.None;*/
            }
        }
        
    }
}
