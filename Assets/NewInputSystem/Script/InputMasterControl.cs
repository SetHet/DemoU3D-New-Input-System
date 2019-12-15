using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputMasterControl : MonoBehaviour
{
    Vector2 move = Vector2.zero;

    public void Move2(InputAction.CallbackContext context){
        move = context.ReadValue<Vector2>();
    }

    void Update(){
        if (move == Vector2.zero) return;
        transform.position += (Vector3)move * Time.deltaTime;
    }
    
}
