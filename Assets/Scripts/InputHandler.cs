using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public static Action<Vector2> DirectionButtonPressed;

    private readonly HashSet<KeyCode> _directionButtons = new()
    {
        KeyCode.W, KeyCode.A, KeyCode.S, KeyCode.D,
        KeyCode.UpArrow, KeyCode.LeftArrow, KeyCode.RightArrow, KeyCode.DownArrow
    };

    void Update()
    {
        foreach (var button in _directionButtons)
        {
            if (Input.GetKey(button))
            {
                var dir = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
                Debug.Log(dir.ToString());
                DirectionButtonPressed?.Invoke(dir);
            }
        }
    }
}
