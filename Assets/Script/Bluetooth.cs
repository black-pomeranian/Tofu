using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using toio;

public class Bluetooth : MonoBehaviour
{
    public ConnectType connectType;
    CubeManager cm;
    Cube cube;

    async void Start()
    {
        // ConnectType.Auto - ビルド対象に応じて内部実装が自動的に変わる
        // ConnectType.Simulator - ビルド対象に関わらずシミュレータのキューブで動作する
        // ConnectType.Real - ビルド対象に関わらずリアル(現実)のキューブで動作する
        cm = new CubeManager(connectType);
        //cube = cm.syncCubes[0];
        await cm.MultiConnect(1);
    }


    void Update()
    {
        //cube.TurnLedOn(255, 0, 0, 9);
        
        foreach (var cube in cm.syncCubes)
        {
            cube.TurnLedOn(255, 0, 0, 9);
            cube.Move(50, -50, 100);
            Debug.Log(cube.pose);
        }
    }
}
