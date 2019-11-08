using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HP : MonoBehaviour
{

     private float health = 100;

    public GameObject deathEffect;

    [Header("Unity Stuff")]
    public Image healthBar;

    public void TakeDamage(float amount)
    {
        health -= amount;

       healthBar.fillAmount = health / 100f;
        Debug.Log("oi m8");
        if (health < 0)
        {
            Die();
        }
    }

    void Die()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
        SceneManager.LoadScene("GameOver");
    }
}

