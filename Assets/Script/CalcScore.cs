using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalcScore : MonoBehaviour
{
    public int score = 0;

    void Start()
    {
        
    }

    void Update()
    {
        score += (int)Mathf.Ceil(Time.deltaTime * 10.0f);
        Debug.Log(score);
    }
}
