using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPickups : MonoBehaviour
{

    // objects variables
    private int money;
    private int health;

    // text for testing till graphic UI implemented
    public Text moneyText;
    public Text healthText;

    // Start is called before the first frame update
    void Start()
    {
        money = 0;
        health = 3;
        SetMoneyText();
        SetHealthText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Coin"))

        {
            Debug.Log("Inside player script pick up coin");
            //SoundManagerScript.PlaySound("CoinPickUp");
            //Destroy(collision.gameObject);
            //collision.gameObject.SetActive(false);
            ++money;
            SetMoneyText();
        }
        else if (collision.CompareTag("Gem"))
        {
            collision.gameObject.SetActive(false);
            money += 10;
            SetMoneyText();
        }
        else if (collision.CompareTag("Potion"))
        {
            if (health >= 0 && health < 4)
            {
                collision.gameObject.SetActive(false);
                ++health;
                SetHealthText();
            }

        }
    }

    private void SetMoneyText()
    {
        moneyText.text = money.ToString();
        // maybe calling some method here for future stuff
    }

    private void SetHealthText()
    {
        healthText.text = health.ToString();

    }
}
