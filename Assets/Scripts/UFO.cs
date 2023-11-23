using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UFO : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb2d;
    private int count = 0;
    public Text score_02;
    [SerializeField] Text winText;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        rb2d.AddForce(movement * speed);
    }
    private void OnTriggerEnter2D(Collider2D obiekt)
    {
        if (obiekt.gameObject.CompareTag("collectable"))
        {
            count++;
            Destroy(obiekt.gameObject);
            if (count >= 4)
            {
                winText.gameObject.SetActive(true);
                SceneManager.LoadScene("Level02");
                //current index +1
            }

        }
    }
}
