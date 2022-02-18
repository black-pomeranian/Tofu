using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 1.0f;
    Bluetooth bluetooth;
    string pose;
    // Start is called before the first frame update
    void Start()
    {
        bluetooth = this.gameObject.GetComponent<Bluetooth>();
        pose = bluetooth.pose;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) || pose=="Up")
        {
            transform.position += transform.up * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow) || pose == "Down")
        {
            transform.position -= transform.up * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow) || pose == "Right")
        {
            transform.position += transform.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow) || pose == "Left")
        {
            transform.position -= transform.right * speed * Time.deltaTime;
        }
    }
}
