using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowGameOverTxt : MonoBehaviour
{
    bool gameover = false;
    public GameObject gameOverTxt;
    TofuStatus ts;
    // Start is called before the first frame update
    void Start()
    {
        ts = GameObject.Find("Tofu 1").GetComponent<TofuStatus>();
    }

    // Update is called once per frame
    void Update()
    {
        gameover = ts.gameOver;
        Debug.Log(gameover);
        if (gameover)
        {
            gameOverTxt.SetActive(true);
        }
       
    }
}
