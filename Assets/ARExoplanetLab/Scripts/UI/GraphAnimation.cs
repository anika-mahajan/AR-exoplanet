using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraphAnimation : MonoBehaviour
{
    private float min;
	private float max;
    private bool goingRight;
    private float speed = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        min = transform.position.x;
		max = transform.position.x+650;
        goingRight = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(goingRight) {
            if(transform.position.x < max) {
                transform.position = new Vector3(transform.position.x + speed, transform.position.y, transform.position.z);
            } else {
                transform.SetSiblingIndex(0);
                goingRight = false;
            }
        } else {
            if(transform.position.x > min) {
                transform.position = new Vector3(transform.position.x - speed, transform.position.y, transform.position.z);
            } else {
                transform.SetSiblingIndex(6);
                goingRight = true;
            }
        }
        
    }
}
