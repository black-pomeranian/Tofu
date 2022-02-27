using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateMeteo : MonoBehaviour
{
    GameObject meteo1, meteo2, meteo3, meteo4, meteo5;
    float count = 0.0f;
    [SerializeField] float diff = 2.0f;
    TofuStatus ts;
    bool gameover = false;
    float time;
    float size;

    GameStatus gs;

    void Start()
    {
        meteo1 = (GameObject)Resources.Load("Asteroid_1");
        meteo2 = (GameObject)Resources.Load("Asteroid_2");
        meteo3 = (GameObject)Resources.Load("Asteroid_3");
        meteo4 = (GameObject)Resources.Load("Asteroid_4");
        meteo5 = (GameObject)Resources.Load("Asteroid_5");

        ts = GameObject.Find("Tofu 1").GetComponent<TofuStatus>();
        gs = GameObject.Find("GameMaster").GetComponent<GameStatus>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gs.isStart)
        {
            if (diff < 0)
            {
                diff = 2.0f;
            }

            gameover = ts.gameOver;
            if (!gameover)
            {
                count += Time.deltaTime;
                time += Time.deltaTime;
                size = Random.Range(1.0f, 1.0f + time / 10);

                if (diff < count)
                {
                    diff -= Time.deltaTime;
                    if (diff <= 0)
                    {
                        diff = 0.1f;
                    }
                    count = 0.0f;
                    int rnd = Random.Range(0, 5);
                    float pos_x = 50.0f;
                    float pos_y = Random.Range(-0.17f, 0.17f);
                    float pos_z = Random.Range(-0.25f, 0.25f);

                    if (rnd == 0)
                    {
                        GameObject meteo = Instantiate(meteo1, new Vector3(pos_x, pos_y, pos_z), Quaternion.identity);
                        meteo.transform.localScale = new Vector3(size, size, size);
                    }
                    else if (rnd == 1)
                    {
                        GameObject meteo = Instantiate(meteo2, new Vector3(pos_x, pos_y, pos_z), Quaternion.identity);
                        meteo.transform.localScale = new Vector3(size, size, size);
                    }
                    else if (rnd == 2)
                    {
                        GameObject meteo = Instantiate(meteo3, new Vector3(pos_x, pos_y, pos_z), Quaternion.identity);
                        meteo.transform.localScale = new Vector3(size, size, size);
                    }
                    else if (rnd == 3)
                    {
                        GameObject meteo = Instantiate(meteo4, new Vector3(pos_x, pos_y, pos_z), Quaternion.identity);
                        meteo.transform.localScale = new Vector3(size, size, size);
                    }
                    else if (rnd == 4)
                    {
                        GameObject meteo = Instantiate(meteo5, new Vector3(pos_x, pos_y, pos_z), Quaternion.identity);
                        meteo.transform.localScale = new Vector3(size, size, size);
                    }
                }
            }
        }
    }
}
