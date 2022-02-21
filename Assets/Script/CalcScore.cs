using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalcScore : MonoBehaviour
{
    public int score = 0;
    TofuStatus ts;
    bool gameover = false;
    void Start()
    {
        ts = GameObject.Find("Tofu 1").GetComponent<TofuStatus>();
    }

    void Update()
    {
        gameover = ts.gameOver;
        if (!gameover)
        {
            score += (int)Mathf.Ceil(Time.deltaTime * 10.0f);
        }
        
        //Debug.Log(score);
    }
}
