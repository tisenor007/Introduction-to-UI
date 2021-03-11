using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public float health;
    public Text healthText;

    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;
    public GameObject heart4;
    private void Start()
    {
        //health = 0;
    }
    private void Update()
    {
        healthText.text = health.ToString();
        //yes I know very ugly and long code........
        if (health <= 25 && health >= 1)
        {
            heart1.SetActive(true);
        }
        else if (health <= 0)
        {
            heart1.SetActive(false);
        }
        if (health <= 50 && health >= 25)
        {
            heart2.SetActive(true);
        }
        else if (health < 25)
        {
            heart2.SetActive(false);
        }
        if (health <= 75 && health >= 50)
        {
            heart3.SetActive(true);
        }
        else if (health < 50)
        {
            heart3.SetActive(false);
        }
        if (health <= 100 && health >= 75)
        {
            heart4.SetActive(true);
        }
        else if (health < 75)
        {
            heart4.SetActive(false);
        }
        else if (health <= 0)
        {
            heart1.SetActive(false);
            heart2.SetActive(false);
            heart3.SetActive(false);
            heart4.SetActive(false);
        }
    }
    public void AddHealth()
    {
        health = health + 5;
        //caps at 100
        if (health >= 100)
        {
            health = 100;
        }
    }
    public void RemoveHealth()
    {
        health = health - 5;
        //caps at 0
        if (health <= 0)
        {
            health = 0;
        }
    }
    public void ResetHealth()
    {
        health = 0;
    }
}
