using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Gamemanager : MonoBehaviour
{
    public float speed;
    public float timeLeft = 20;
    private int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(moveX, 0 , moveY).normalized * speed * Time.deltaTime;

        transform.Translate(move);

        if (timeLeft <= 0)
        {
            Debug.Log("GameOver! Eindscore: " + score);

            enabled = false;
            return;
        }

        timeLeft -= Time.deltaTime;

        Debug.Log("Tijd: " + Mathf.Round(timeLeft) + " | Score: " + score);
    }

    void OnTriggerEnter(Collider other)
    {

        Debug.Log("!!");
        if (other.gameObject.CompareTag("Pickup"))
        {
            score += 10;

            Debug.Log(score);

            Destroy(other.gameObject);
        }
    }
}
