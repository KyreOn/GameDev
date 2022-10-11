using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChangeHandler : MonoBehaviour
{
    public static Action<int> ChangeButtonPressed;
    private readonly HashSet<KeyCode> _camerasButton = new()
    {
        KeyCode.Keypad1, KeyCode.Keypad2, KeyCode.Keypad3,
        KeyCode.Keypad4, KeyCode.Keypad5, KeyCode.Keypad6,
        KeyCode.Keypad7, KeyCode.Keypad8, KeyCode.Keypad9,
        KeyCode.Keypad0
    };
    void Update()
    {
        foreach (var button in _camerasButton)
        {
            if (Input.GetKeyDown(button))
                ChangeButtonPressed?.Invoke((int)button - 256);
        }
        if (Input.GetKeyDown(KeyCode.Space))
            ChangeButtonPressed?.Invoke(-1);
    }
}
