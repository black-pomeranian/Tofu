using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using toio;

public class Bluetooth : MonoBehaviour
{
    public ConnectType connectType;
    CubeManager cm;
    public string pose;
    GameStatus gs;
    async void Start()
    {
        gs = GameObject.Find("GameMaster").GetComponent<GameStatus>();
        cm = new CubeManager(connectType);
        await cm.MultiConnect(1);
    }


    void Update()
    {
        foreach (var cube in cm.syncCubes)
        {
            cube.TurnLedOn(255, 0, 0, 9);
            cube.Move(50, -50, 100);
            pose = cube.pose.ToString();
            gs.isStart = true;
        }
        if (gs.isToio)
        {
            foreach (var cube in cm.syncCubes)
            {
                cube.TurnLedOn(255, 0, 0, 9);
                cube.Move(50, -50, 100);
                pose = cube.pose.ToString();
                gs.isStart = true;
            }
        }
    }
}
