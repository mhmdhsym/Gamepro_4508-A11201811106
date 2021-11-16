using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	private Rigidbody2D rb;
	public float speed;
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Boundry();
    }

    void Boundry()
    {
    	Vector2 temp=transform.position;
    	if(temp.x<-1)
    	{
    		temp.x=-1;
    		transform.position=temp;
    	}
    	if(temp.x>1)
    	{
    		temp.x=1;
    		transform.position=temp;
    	}
    	if(temp.y<-2.1f)
    	{
    		temp.y=-2.1f;
    		transform.position=temp;
    	}
    	if(temp.y>2.1f)
    	{
    		temp.y=2.1f;
    		transform.position=temp;
    	}
    }
    public void Left()
    {
    	Vector2 temp=transform.position;
    	temp.x-=1;
    	transform.position=temp;
    }

    public void Right()
    {
    	Vector2 temp=transform.position;
    	temp.x+=1;
    	transform.position=temp;
    }

    public void Up()
    {
    	rb.velocity=new Vector2(0,speed*Time.deltaTime);
    }

    public void Down()
    {
    	rb.velocity=new Vector2(0, (-1)*speed*Time.deltaTime);
    }

    public void Stop()
    {
    	rb.velocity=new Vector2(0,0);
    }
}
