using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayerCharacter
{
    public class PlayerMovement : MonoBehaviour
    {

        public Rigidbody2D rigid;

        Vector2 moveAxis = Vector2.zero;

        private void FixedUpdate()
        {
            MovePlayer();
        }

        public void SetMoveAxis(Vector2 vec)
        {
            moveAxis = vec;
        }

        void MovePlayer()
        {
            Vector2 y = rigid.velocity.y * Vector2.up;
            Vector2 x = moveAxis.x * Vector2.right;
            rigid.velocity = y + x;
        }

    }
}