using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{   

    public float health;
    public Image Healthbar;
    public float MaxHealth;
    public Text HealthText;

  

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Healthbar.fillAmount = health / MaxHealth;
        HealthText.text = health.ToString() + "%";

        if (health > 100)
            health = 100;
    }
    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0)
        {
            Die();
        }
    }
    public void healthPickup()
    {
        
        health += 25;
    }
    public void Die()
    {
    }
    
    private void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.CompareTag("HealthPickup"))
        {
            if (Input.GetKeyDown(KeyCode.E)) { 
            healthPickup();
            Destroy(collision.gameObject);
            }

        }
    }
}
