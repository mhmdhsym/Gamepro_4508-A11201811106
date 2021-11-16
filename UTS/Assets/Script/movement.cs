using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
	public float speed;
	public float maxSpeed;
    // Start is called before the first frame update
    void Start()
    {
        speed+=0.003f*Time.time;
        if(speed>=maxSpeed)
        {
        	speed=maxSpeed;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
    	Vector2 temp=transform.position;
    	temp.y-=speed*Time.deltaTime;
    	transform.position=temp;
    }

}
