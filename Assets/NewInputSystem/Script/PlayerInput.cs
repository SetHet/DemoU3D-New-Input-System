using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace PlayerCharacter
{
    public class PlayerInput : MonoBehaviour
    {
        public PlayerMovement playerMovement;


        public void Move(InputAction.CallbackContext context)
        {
            Vector2 moveAxis = context.ReadValue<Vector2>();

            playerMovement.SetMoveAxis(moveAxis);
        }

    }
}