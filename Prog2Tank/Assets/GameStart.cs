using UnityEngine;
using System.Collections;

public class GameStart : MonoBehaviour {

	bool mousinbutton = true;
	//GameObject TargetTank = GameObject.FindWithTag("lampSelect");
	// Use this for initialization
	void Start () 
	{
	
		//gameObject.rigidbody.centerOfMass = new Vector3(0,0,0);
		//gameObject.rigidbody.AddTorque (1f,0,0);
		//gameObject.rigidbody.AddRelativeForce (0, 0, 2); // (Vector3.left * Time.deltaTime*20);
		//gameObject.transform.Rotate (Vector3.left * Time.deltaTime*20);
	}
	
	// Update is called once per frame
	void Update () 
	{

		var TargetTank = GameObject.FindWithTag("lampSelect");
		var Position = TargetTank.transform.position;
		if (Position.y != 1.1f & mousinbutton == false) 
		{
			mousinbutton = false;
			TargetTank.transform.position = new Vector3(Position.x, 5f , Position.z);
	
		}
		mousinbutton = false;

		//gameObject.rigidbody.rotation(Vector3.left * Time.deltaTime*20)//transform.Rotate (Vector3.left * Time.deltaTime*20);
		//var Cube = new Vector3

	}
	void OnMouseOver()
	{

		mousinbutton = true;
		//TargetTank = new GameObject("buttomlamp");

		var TargetTank = GameObject.FindWithTag("lampSelect");
		var Position = TargetTank.transform.position;
		//Debug.Log (""+Position.x);
		TargetTank.transform.position = new Vector3(Position.x, 2.4f , Position.z);
		//TargetTank.transform.position = Vector3(0, 10, 0);
		//TargetTank.transform.position = Vector3 (1,1,1);
		//TargetTank.transform.position
		//TargetTank.transform.position = Vector3(-3.33,2.4,-1.1);
//		var TargetTank = GameObject.FindWithTag("lampSelect");
//		var positionTargetTank = TargetTank.transform.position;
//		var MyPosition = gameObject.transform.position;


	}

	void OnMouseDown()   
	{
		Application.LoadLevel (1);

	}
}
