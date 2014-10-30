using UnityEngine;
using System.Collections;
using System;

public class MovCh1 : MonoBehaviour {

	public Rigidbody2D RocketRb;
	public float SpeedMove = 30;
	public float SpeedVect = 30;
	public float SpeedRock = 30;

	public float gradz = 0;
	public int life = 100;
	public float ammoBase = 10;
	public bool moove = true;
	public float cdTimeRb = 2;
	float cdRb = 0;

	//public float ammoBase = 100;


	void Start () 
	{	
		//gradz = Math.PI * 90/180;
		//rigidbody2D.AddRelativeForce(new Vector2(0,1)*SpeedMove);
	}

	public void TakeDemage (int demage) 
	{
		//life = life - demage;
		Debug.Log("life = "+life);
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.name == "meteor") {
			Destroy(gameObject);
			Application.Quit ();
		}
		if (other.gameObject.name == "bonus") {
			ammoBase = ammoBase + 10;
			SpeedRock = SpeedRock + 15;
			Destroy (other.gameObject);
		}


	}


	void Update () 
	{
		if (moove == true) 
		{
			if (cdRb == 0)
			{
				rigidbody2D.AddRelativeForce (new Vector2 (0, 1) * SpeedMove);
				cdRb = 1;
			}

		float right = 0;
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			right = SpeedVect;
			gradz = gradz+SpeedVect;//(SpeedMove/16);
			//rigidbody2D.velocity = new Vector2( -SpeedPlayer, 0 );
		}
		if (Input.GetKey(KeyCode.RightArrow))
		{
			right = -SpeedVect;
			gradz = gradz-SpeedVect;
			//rigidbody2D.velocity = new Vector2( -SpeedPlayer, 0 );
		}
		if (right != 0)
		{
			rigidbody2D.Sleep();
			rigidbody2D.WakeUp();
				rigidbody2D.transform.Rotate (0, 0, right);
			rigidbody2D.AddRelativeForce (new Vector2 (0,1) * SpeedMove);

		}

			if (Input.GetKey(KeyCode.Space) & ammoBase > 0 &   Time.time>= cdRb)
		{

				Debug.Log ("ppp  "+gradz);

			var k = new kk();
			k.trk = transform.position;
			k.RBk = RocketRb;
			k.speed = SpeedRock;
			k.gradzR = gradz;
			k.newUnit();// = RocketRb;

			ammoBase = ammoBase -1;
			cdRb = Time.time + cdTimeRb;
//			
		}

		}
		else
		{
			rigidbody2D.Sleep();
		}
	}
}
