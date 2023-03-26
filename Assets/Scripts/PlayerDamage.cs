using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerDamage : MonoBehaviour
{
    [SerializeField] int MaxHealth = 10;
    [SerializeField] int Health;
    [SerializeField] float DamageCoolDown = 0.2f;
    [SerializeField] GameObject HealthBar;
    private Slider slider;
    private float nextDamage = 0.0f;
    private int Damage;
    [SerializeField] float scale = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        Health = MaxHealth;
        slider = HealthBar.GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Health < 0)
        {
            Debug.Log("Player Dead");
        }
        
    }
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Enemy" && Time.time > nextDamage + DamageCoolDown)
        {   
            Health -= other.gameObject.GetComponent<EnemyDamageScript>().Damage;
            nextDamage = Time.time + DamageCoolDown;
            scale = Health / MaxHealth;
            slider.value = scale;

        }
    }
}
