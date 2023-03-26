using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    [SerializeField] int bulletForce = 5000;
    [SerializeField] float bulletSize = 0.05f;
    [SerializeField] float destructionDelay = 0.08f;
    private int bulletHardKill = 30;
    [SerializeField] int bulletLife = 3;
    private float firedAt;
    public int bulletDamage = 4;
    private Rigidbody rb;
    // Start is called before the first frame update
    private void Start()
    {
          rb = GetComponent<Rigidbody>();
          transform.rotation = transform.parent.rotation;
          transform.Rotate(-90,0,0,Space.Self);
          gameObject.transform.parent = null;
          gameObject.transform.localScale = new Vector3(bulletSize,bulletSize,bulletSize);
          firedAt = Time.time;
          rb.AddForce(transform.up * bulletForce * Time.deltaTime);
          Destroy(gameObject,bulletHardKill);
    }

    private void OnCollisionEnter(Collision other)
    {
            Destroy(gameObject,destructionDelay);
    }
    private void FixedUpdate() 
    {
          if (Time.time > firedAt + bulletLife)
          {
               rb.useGravity = true;
          }
    }
}