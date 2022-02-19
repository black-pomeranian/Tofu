using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateMeteo : MonoBehaviour
{
    GameObject meteo1, meteo2, meteo3, meteo4, meteo5;
    float count = 0.0f;
    float diff = 3.0f;

    void Start()
    {
        meteo1 = (GameObject)Resources.Load("Asteroid_1");
        meteo2 = (GameObject)Resources.Load("Asteroid_2");
        meteo3 = (GameObject)Resources.Load("Asteroid_3");
        meteo4 = (GameObject)Resources.Load("Asteroid_4");
        meteo5 = (GameObject)Resources.Load("Asteroid_5");
    }

    // Update is called once per frame
    void Update()
    {
        count += Time.deltaTime;
        if (diff < count)
        {
            count = 0.0f;
            int rnd = Random.Range(0, 5);
            float pos_x = Random.Range(-0.3f, 0.3f);
            float pos_y = Random.Range(-0.2f, 0.2f);
            pos_x = 0;
            pos_y = 0;
            if (rnd == 0)
            {
                Instantiate(meteo1, new Vector3(pos_x, pos_y, 50.0f), Quaternion.identity);
            }
            else if (rnd == 1)
            {
                Instantiate(meteo2, new Vector3(pos_x, pos_y, 50.0f), Quaternion.identity);
            }
            else if (rnd == 2)
            {
                Instantiate(meteo3, new Vector3(pos_x, pos_y, 50.0f), Quaternion.identity);
            }
            else if (rnd == 3)
            {
                Instantiate(meteo4, new Vector3(pos_x, pos_y, 50.0f), Quaternion.identity);
            }
            else if (rnd == 4)
            {
                Instantiate(meteo5, new Vector3(pos_x, pos_y, 50.0f), Quaternion.identity);
            }
        }
        
    }
}
