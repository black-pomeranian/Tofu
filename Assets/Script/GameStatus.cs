using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStatus : MonoBehaviour
{

    void Awake()
    {
        Application.targetFrameRate = 60; //60FPSに設定
    }

    public bool isToio = false;
    public bool isStart = false;
    bool selectSound = true;
    public AudioClip selectSE;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(selectSound && (isToio || isStart)){
            AudioSource.PlayClipAtPoint(selectSE, transform.position, 1f);
            selectSound = false;
        }
    }
}
