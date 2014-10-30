using UnityEngine;
using System.Collections;

public class MovTarg : MonoBehaviour 
{

	public float SpeedTarget;
	float Horiz;
	float Vertic;
	public double coolDownSec;
	double coolDown;

	void Update () 
	{
		if (Time.time >= coolDown) 
		{
			rigidbody2D.Sleep();
			rigidbody2D.WakeUp();
			coolDownSec = Random.Range(2,20)*0.1;
			float up = Random.Range(-10,10);
			float dw = Random.Range(-10,10);
			//up = 1;
			//dw = 1;
			rigidbody2D.AddForce( new Vector2 (up*SpeedTarget,dw*SpeedTarget));
			//Debug.Log("up"+up+" DW "+dw);
			coolDown = Time.time + coolDownSec;
			//
		}
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		//Debug.Log(""+other.gameObject.tag);
		if (other.gameObject.tag == "MyPlayer" && other.gameObject.tag == "Enemy")
		{
			gameObject.rigidbody2D.Sleep();
			gameObject.rigidbody2D.WakeUp();
			other.rigidbody2D.Sleep();
			other.rigidbody2D.WakeUp();

			//Debug.Log(""+gameObject.);
		}
	}
}
