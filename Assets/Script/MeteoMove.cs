using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteoMove : MonoBehaviour
{
    Transform meteoTransform;
    float meteoSpeed = 1.0f;

    void Start()
    {
        meteoTransform = this.transform;
    }

    void Update()
    {
        Vector3 pos = meteoTransform.position;
        pos.x -= meteoSpeed;
        if (pos.x < -10)
        {
            Destroy(this.gameObject);
        }
        meteoTransform.position = pos;
    }
}
