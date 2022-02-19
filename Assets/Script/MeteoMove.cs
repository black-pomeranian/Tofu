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
        pos.z -= meteoSpeed;
        meteoTransform.position = pos;
    }
}
