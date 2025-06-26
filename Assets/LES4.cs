using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LES4 : MonoBehaviour
{

    [SerializeField] private float speed;
    [SerializeField] GameObject coinPrefab;
    // Start is called before the first frame update
    void Start()
    {
        float randVal = Random.Range(-10,10);
        Instantiate(coinPrefab , new Vector3(randVal, 0, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        float input = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * input * speed * Time.deltaTime);
    }
}
