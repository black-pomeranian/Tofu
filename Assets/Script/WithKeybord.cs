using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WithKeybord : MonoBehaviour
{
    GameStatus gs;
    GameObject startUI;
    public AudioClip selectSE;

    void Start()
    {
        gs = GameObject.Find("GameMaster").GetComponent<GameStatus>();
        startUI = GameObject.Find("Start");
    }
    public void OnClick()
    {
        AudioSource.PlayClipAtPoint(selectSE, transform.position,100);
        gs.isStart = true;
        startUI.SetActive(false);
    }
}
