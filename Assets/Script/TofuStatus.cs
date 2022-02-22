using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TofuStatus : MonoBehaviour
{
    public bool gameOver = false;
    public AudioClip explosionSE;
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
            AudioSource.PlayClipAtPoint(explosionSE, transform.position);
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
            Debug.Log("Game Over");
            
        }
    }
}
