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

        void testCameraRender_Waldo()
        {
            Texture2D image = new Texture2D(cam.targetTexture.width, cam.targetTexture.height);
            image.ReadPixels(new Rect(0, 0, cam.targetTexture.width, cam.targetTexture.height), 0, 0); //Guarda la imagen en pantalla
            image.Apply(); //Aplica los cambios de pixel

            //para calcular la profundidad puede servir esto:    https://answers.unity.com/questions/877170/render-scene-depth-to-a-texture.html
        }

    }
}