using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCursorState : MonoBehaviour
{

    public CursorLockMode mode;
    public bool visible;
    

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = mode;
        Cursor.visible = visible;
    }

}
