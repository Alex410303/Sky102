using UnityEngine;
using System.Collections;

public class bullScr : MonoBehaviour {

	float latenc;
	float cd = 0.7f;
	bool imp = false;
	// Use this for initialization
	void Start () 
	{
		Destroy (gameObject,4);
		//latenc = Time.time + cd;

	}

	void Update () 
	{

//		if (Time.time  >= latenc & imp == false) 
//		{
//		
//			var TargetTank = GameObject.FindWithTag("Enemy");
//			var positionTargetTank = TargetTank.transform.position;
//			var MyPosition = gameObject.transform.position;
//
//			gameObject.rigidbody2D.AddForce((positionTargetTank - MyPosition) * 30);
//			imp = true;
//		}
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "lifePoint") 
		{
				//Destroy(gameObject);
		}
		if (other.gameObject.tag == "MyPlayer2") 
		{

			Destroy(other.gameObject);
		}
	}
}


