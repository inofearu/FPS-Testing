using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damageScript : MonoBehaviour
{
    private Rigidbody rb;
    private GameObject Gun;
    private int health = 10;
    private int damage;
    private GameObject gun;
    private gunFire gunFire;
    // Start is called before the first frame update
    private void Start()
    {
        gun = GameObject.Find("Gun");
        gunScript = gun.GetComponent<gunFire>();
    }

    // Update is called once per frame
    private void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.tag == "Bullet")
        {
            health -= damage;
            if (health < 0)
            {
                rb.useGravity = true;
                rb.constraints = RigidbodyConstraints.None;
            }
        }
        
    }
}
