using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed;
    float moveHorizontal;
    float moveVertical;
    //public Text countText;
    //public Text winText;
    private int count;
    Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        count = 0;
        //winText.text = "";
        //SetCountText();
    }

    void Update()
    {
        moveHorizontal = Input.GetAxisRaw("Horizontal");
        moveVertical = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {

        rb2d.velocity = new Vector2(moveHorizontal * speed, moveVertical * speed);
        //Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        //transform.Translate(new Vector3(moveHorizontal, moveVertical, 0) * speed * Time.deltaTime);
        //rb2d.AddForce(movement * speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("PickUp"))
        {
            collision.gameObject.SetActive(false);
            count++;
            //SetCountText();
        }
    }

   /* private void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 5)
            winText.text = "You Win!";
    }*/
}
