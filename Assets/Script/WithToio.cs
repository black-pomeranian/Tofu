using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WithToio : MonoBehaviour
{

    GameStatus gs;
    GameObject startUI;
    public AudioClip selectSE;
    AudioSource audioSource;

    void Start()
    {

        gs = GameObject.Find("GameMaster").GetComponent<GameStatus>();
        startUI = GameObject.Find("Start");
        audioSource = GetComponent<AudioSource>();
    }

    public void OnClick()
    {
        audioSource.Play();//.PlayOneShot(selectSE);
        gs.isToio = true;
        startUI.SetActive(false);

    }
}
