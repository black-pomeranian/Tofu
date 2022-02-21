using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TofuStatus : MonoBehaviour
{
    public bool gameOver = false;
    [SerializeField] GameObject explosionPrefab;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Meteo")
        {
            gameOver = true;
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
            Debug.Log("Game Over");
            
        }
    }
}
