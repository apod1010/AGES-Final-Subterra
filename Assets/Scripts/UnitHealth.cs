using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnitHealth : MonoBehaviour
{
    #region Fields
    public float maxHealth = 100f;
    private float currentHealth = 100f;
    public float healthPackValue = 20f;

    public float maxBreath = 100f;
    private float currentBreath = 100f;
    public float airCanCapacity = 25f;


    public float BreathRate = 1f;
    public float SuffocationRate = 10f;

    public Slider healthSlider;
    public Slider breathSlider;

   // public Text scrapText;
   // private int scrapCount;
    
    #endregion
    //[SerializeField]
    //private int damageTaken = 20;

    private void Start()
    {
        currentHealth = maxHealth;
        currentBreath = maxBreath;
        //scrapCount = 0;

        //SetScrapCount();
    }

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "Air")
        {
            currentBreath += airCanCapacity;
            UpdateBreath();

            Destroy(collision.gameObject);
        }
        if(collision.gameObject.tag == "Health")
        {
            currentHealth += healthPackValue;
            UpdateHealth();

            Destroy(collision.gameObject);
        }
        //if (collision.gameObject.tag == "Scrap")
        //{
        //    scrapCount = scrapCount + 1;
        //    SetScrapCount();

        //    Destroy(collision.gameObject);
        //}
    }

    #region Value Updater
    public void UpdateHealth()
    {
        healthSlider.value = currentHealth;
    }
    public void UpdateBreath()
    {
        breathSlider.value = currentBreath;
    }
    //void SetScrapCount()
    //{
    //    scrapText.text = "Scrap: " + scrapCount.ToString();
    //}
    #endregion

    private void Update()
    {
        currentBreath -= BreathRate * Time.deltaTime;
        UpdateBreath();

        if (currentBreath < 0)
            currentBreath = 0;

        if (currentBreath > maxBreath)
            currentBreath = maxBreath;

        if (maxBreath < 1)
            maxBreath = 1;

        if (currentBreath < 1)
        {

            currentHealth -= SuffocationRate * Time.deltaTime;
            UpdateHealth();

            if (currentHealth < 0)
                currentHealth = 0;

            if (currentHealth > maxHealth)
                currentHealth = maxHealth;

            if (maxHealth < 1)
                maxHealth = 1;

            if (currentHealth < 1)
            {
                Destroy(gameObject);
            }
        }
    }
}
