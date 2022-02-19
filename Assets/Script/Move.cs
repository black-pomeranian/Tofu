using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    float speed = 0.1f;
    Bluetooth bluetooth;
    string pose;
    float rot_x, rot_z = 0f;
    Transform cubeTransform;


    void Start()
    {
        cubeTransform = this.transform;

        bluetooth = this.gameObject.GetComponent<Bluetooth>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = cubeTransform.position;
        pose = bluetooth.pose;

        if (Input.GetKey(KeyCode.UpArrow) || pose=="Back")
        {
            pos.y += speed;
            rot_x = 0;
            rot_z = 20;
        }
        else if (Input.GetKey(KeyCode.DownArrow) || pose == "Front")
        {
            pos.y -= speed;
            rot_x = 0;
            rot_z = -20;
        }
        else if (Input.GetKey(KeyCode.RightArrow) || pose == "Right")
        {
            pos.z -= speed;
            rot_x = -20;
            rot_z = 0;
        }
        else if (Input.GetKey(KeyCode.LeftArrow) || pose == "Left")
        {
            pos.z += speed;
            rot_x = 20;
            rot_z = 0;
        }
        else
        {
            rot_x = 0;
            rot_z = 0;
        }
        cubeTransform.position = pos;
        cubeTransform.rotation = Quaternion.Euler(rot_x, 0, rot_z);
    }
}
