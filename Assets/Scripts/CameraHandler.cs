using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHandler : MonoBehaviour
{
    [SerializeField] public float cameraBoxWidth;
    [SerializeField] public float cameraBoxHeight;
    [SerializeField] public float speed;
    

    private void OnEnable()
    {
        InputHandler.DirectionButtonPressed += MoveCamera;
    }

    void MoveCamera(Vector2 dir)
    {
        var curPosition = transform.position;
        var newX = curPosition.x + speed * dir.x;
        var newZ = curPosition.z + speed * dir.y;
        newX = Math.Max(-0.5f * cameraBoxWidth, Math.Min(0.5f * cameraBoxWidth, newX));
        newZ = Math.Max(-0.5f * cameraBoxHeight, Math.Min(0.5f * cameraBoxHeight, newZ));
        var newPosition = new Vector3(newX, curPosition.y, newZ);
        transform.position = newPosition;
    }
}
