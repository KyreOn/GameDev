using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChanger : MonoBehaviour
{
    [SerializeField] public List<Camera> cameras;
    private void OnEnable()
    {
        CameraChangeHandler.ChangeButtonPressed += ChangeCamera;
    }

    private void ChangeCamera(int num)
    {
        if (num == -1)
        {
            for (var i = 0; i < cameras.Count; i++)
            {
                if (cameras[i].depth != 0)
                {
                    if (i == cameras.Count - 1)
                        cameras[0].depth = 1;
                    else
                        cameras[i + 1].depth = 1;
                    cameras[i].depth = 0;
                    break;
                }
            }
        }
        else
        {
            foreach (var cam in cameras)
                cam.depth = 0;
            cameras[num].depth = 1;
        }    
    }

    private void Start()
    {
        cameras[0].depth = 1;
        for (var i = 1; i < cameras.Count; i++)
            cameras[i].depth = 0;
    }
}
