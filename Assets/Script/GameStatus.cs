using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStatus : MonoBehaviour
{

    public bool isToio = false;
    public bool isStart = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(isStart);
    }
}
