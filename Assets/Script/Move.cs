using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] float speed = 0.01f;
    Bluetooth bluetooth;
    string pose;
    float rot_x, rot_z = 0f;
    Transform cubeTransform;
    GameStatus gs;

    void Start()
    {
        cubeTransform = this.transform;

        bluetooth = this.gameObject.GetComponent<Bluetooth>();

        gs = GameObject.Find("GameMaster").GetComponent<GameStatus>();

    }

    // Update is called once per frame
    void Update()
    {
        if (gs.isToio)
        {
            Vector3 pos = cubeTransform.position;
            pose = bluetooth.pose;

            if (pose == "Back")
            {
                if (pos.y < 0.25)
                {
                    pos.y += speed;
                    rot_x = 0;
                    rot_z = 20;
                }
            }
            else if (pose == "Front")
            {
                if (-0.3 < pos.y)
                {
                    pos.y -= speed;
                    rot_x = 0;
                    rot_z = -20;
                }
            }
            else if (pose == "Left")
            {
                if (-0.5 < pos.z)
                {
                    pos.z -= speed;
                    rot_x = -20;
                    rot_z = 0;
                }
            }
            else if (pose == "Right")
            {
                if (pos.z < 0.5)
                {
                    pos.z += speed;
                    rot_x = 20;
                    rot_z = 0;
                }
            }
            else
            {
                rot_x = 0;
                rot_z = 0;
            }
            cubeTransform.position = pos;
            cubeTransform.rotation = Quaternion.Euler(rot_x, 0, rot_z);
        }
        else
        {
            Vector3 pos = cubeTransform.position;
            pose = bluetooth.pose;

            if (Input.GetKey(KeyCode.UpArrow))
            {
                if (pos.y < 0.25)
                {
                    pos.y += speed;
                    rot_x = 0;
                    rot_z = 20;
                }
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                if (-0.3 < pos.y)
                {
                    pos.y -= speed;
                    rot_x = 0;
                    rot_z = -20;
                }
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                if (-0.5 < pos.z)
                {
                    pos.z -= speed;
                    rot_x = -20;
                    rot_z = 0;
                }
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                if (pos.z < 0.5)
                {
                    pos.z += speed;
                    rot_x = 20;
                    rot_z = 0;
                }
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
}
