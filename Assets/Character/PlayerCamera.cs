using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayerCharacter
{
    public class PlayerCamera : MonoBehaviour
    {
        public Camera cam;
        public Transform player;
        public Vector3 offset = new Vector3(0,2,-20);

        void Update()
        {
            cam.transform.position = player.position + offset;
        }
    }
}