using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class DirectActionInput : MonoBehaviour
{

    public InputAction moveHorizontal;
    public InputAction shoot;
    public float speed;

    void OnEnable() {
        moveHorizontal.Enable();
        shoot.Enable();
    }

    void OnDisable() {
        moveHorizontal.Disable();
        shoot.Disable();
    }

    void Awake() {
        shoot.performed += x => {OnShoot(x);};
    }

    void OnShoot(InputAction.CallbackContext context) {
        Debug.Log("Shoot!");
    }

    void Update()
    {
        float movement = moveHorizontal.ReadValue<float>();
        movement = Mathf.Clamp(movement, -1, 1);

        transform.Translate(speed * Time.deltaTime * movement, 0, 0);
    }
}
