using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Utilities{
    [System.Serializable]
    public class CoolDownTime
    {
        public float timepause = 1f;
        [HideInInspector] public float this_time = 0f;
        public bool auto = true;


        public CoolDownTime(float timepause = 1f, bool auto = true){
            this.timepause = timepause;
            this.auto = auto;
        }

        ///true if cooldown is finish
        public bool TimeOut(){
            if (this_time <= Time.time){
                if (auto)
                    this_time = Time.time + timepause;
                return true;
            }
            return false;
        }

        ///Active new cooldown
        public void Cooldown(){
            this_time = Time.time + timepause;
        }


    }
}