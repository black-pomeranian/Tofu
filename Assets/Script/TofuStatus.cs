using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TofuStatus : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("ok");
        if (other.gameObject.tag == "Meteo")
        {
            Destroy(other.gameObject);
            Debug.Log("Game Over");
        }
    }
}
