using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WithKeybord : MonoBehaviour
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
        gs.isStart = true;
        startUI.SetActive(false);
    }
}
