using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrawScore : MonoBehaviour
{
    int score;
    CalcScore cs;
    GameStatus gs;
    void Start()
    {
        cs = GameObject.Find("GameMaster").GetComponent<CalcScore>();
        gs = GameObject.Find("GameMaster").GetComponent<GameStatus>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gs.isStart)
        {
            score = cs.score;
            Text score_text = this.gameObject.GetComponent<Text>();
            score_text.text = score.ToString();
        }
    }
}
