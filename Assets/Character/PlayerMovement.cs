using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayerCharacter
{
    public class PlayerMovement : MonoBehaviour
    {

        public Rigidbody2D rigid;
        public Collider2D coll;

        Vector2 moveAxis = Vector2.zero;
        bool jump = false;
        public float jumpCoolDown = 0.1f;
        float temp_jumpCoolDownTime = 0;
        bool ground = false;

        private void FixedUpdate()
        {
            GroundedDetect();
            MovePlayer();
            ActionJump();
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

        void GroundedDetect(){
            //Conseguir colisiones del player
            List<ContactPoint2D> contactPoints = new List<ContactPoint2D>();
            int cant = coll.GetContacts(contactPoints);

            //Crear variable temporal para deteccion del suelo, comenzando en falso
            bool temp_ground = false;

            //Recorrer contactos de la colision
            foreach(ContactPoint2D point in contactPoints){

                //Encontrar el angulo de la superficie del contacto
                float angle = Vector2.Angle(point.normal, Vector2.up);

                //Si el angulo es menor que 45, se ha detectado el suelo
                if (angle <= 45){ 
                    temp_ground = true;
                    break; //ya no se requiere buscar más entre contactos
                }
            }

            //mutar estado de contacto con el suelo
            ground = temp_ground;

        }

        public void Jump(){
            jump = true;
        }

        void ActionJump(){
            if (!ground) return; //si no hay suelo, se ignora

            //Revisar si se ha llamado al salto y el cooldown termine 
            if (jump && temp_jumpCoolDownTime < Time.time){

                //Actualizar cooldown
                temp_jumpCoolDownTime = Time.time + jumpCoolDown; 

                //Agregar velocidad vertical al presonaje
                rigid.velocity += Vector2.up * 3;

                //Quitar el llamado al salto
                jump = false;

            }
        }

    }
}