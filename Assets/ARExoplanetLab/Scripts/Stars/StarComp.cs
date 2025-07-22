using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class StarComp: MonoBehaviour 
{
        public string starName;
        public Vector3 position;
        public float radius;
        public float distance;
        public float luminosity;
        public string type;

<<<<<<< HEAD
        public Color color;

=======
>>>>>>> b3e28a0f8b80f86924704d24ea42f3660778493b

    public void intialize(string starName, Vector3 position, float radius, float distance, float luminosity, string type) {
        this.starName = starName;
        this.position = position;
        this.radius = radius;
        this.distance = distance;
        this.luminosity = luminosity;
        this.type = type;
<<<<<<< HEAD
        
        if(string.Equals(this.type, "Main Sequence")) {
            this.color = Color.yellow;
        } else {
            this.color = Color.red;
        }
        
=======
>>>>>>> b3e28a0f8b80f86924704d24ea42f3660778493b
    }
}
