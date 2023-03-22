using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GunFire : MonoBehaviour
{
    [SerializeField] GameObject Bullet;
    [SerializeField] float FireCooldown = 0.5f;
    private float nextFire = 0.0f;
    // Start is called before the first frame update
    private void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        if(Mouse.current.leftButton.isPressed && Time.time > nextFire)
        {
            nextFire = FireCooldown + Time.time;
            Shoot();
        }
    }

    private void Shoot()
    {
        Instantiate(Bullet, transform.position, Quaternion.identity, gameObject.transform);
    }
}