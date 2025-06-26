using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermove : MonoBehaviour
{

    public float speed = 1f;
    public ScoreManager scoreManager;
    // Start is called before the first frame update
    void Start()
    {
        //if (scoreManager == ?)
        //{
        //  Debug.LogError("Scoremanager niet ingesteld"); 
        //}
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        Vector3 move = new Vector3(moveX, 0f, 0f);
        transform.Translate(move);
    }

    void OnTriggerEnter(Collider other)
    {
        // Check of het een munt is
        if (other.name == "Coin")
        {
            scoreManager.Addscore(10); // Roep de AddScore methode van de je score-script aan en geef 10 punten mee

            //Geef in de console een bericht dat je een munt hebt gepakt!
            Debug.Log("Munt gepakt!");

            //Vernietig de munt
            Destroy(other.gameObject);
        }
    }
}
