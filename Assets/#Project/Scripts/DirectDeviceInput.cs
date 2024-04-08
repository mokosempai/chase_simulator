using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class DirectDeviceInput : MonoBehaviour
{

    [SerializeField] float speed;

    void Update()
    {
        Keyboard keyboard = Keyboard.current;

        float movement = speed * Time.deltaTime;

        if (keyboard.aKey.isPressed) {
            transform.Translate(-movement, 0, 0);        
        }

        if (keyboard.dKey.isPressed) {
            transform.Translate(movement, 0, 0);        
        }

        
    }
}
