using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WithToio : MonoBehaviour
{

    GameStatus gs;
    GameObject startUI;

    void Start()
    {

        gs = GameObject.Find("GameMaster").GetComponent<GameStatus>();
        startUI = GameObject.Find("Start");
    }

    public void OnClick()
    {

        gs.isToio = true;
        startUI.SetActive(false);

    }
}
