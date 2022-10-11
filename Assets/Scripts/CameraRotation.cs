using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    [SerializeField] private float speed;
    void Update()
    {
        transform.RotateAround(new Vector3(0, 0, 0), Vector3.up, speed * Time.deltaTime);
    }
}
