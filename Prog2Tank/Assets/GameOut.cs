using UnityEngine;
using System.Collections;

public class GameOut : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
//		var TargetTank = GameObject.FindWithTag("lampSelect");
//		var Position = TargetTank.transform.position;
//		if (Position.y != 2.4f & Position.y != 1.1f ) 
//		{
//			TargetTank.transform.position = new Vector3(Position.x, 5f , Position.z);
//			
//		}
//		var TargetTank = GameObject.FindWithTag("lampSelect");
//		var Position = TargetTank.transform.position;
//		if (Position.y == 2.4f) {
//			mousinbutton = false;
//		} else {
//			mousinbutton = false;
//		}
//		if (mousinbutton == false & Position.y == 1.1f) 
//		{
//			TargetTank.transform.position = new Vector3(Position.x, 5f , Position.z);
//		}
	}

	void OnMouseOver()
	{

				//TargetTank = new GameObject("buttomlamp");
		
				var TargetTank = GameObject.FindWithTag ("lampSelect");
				var Position = TargetTank.transform.position;
				//Debug.Log (""+Position.x);
				TargetTank.transform.position = new Vector3 (Position.x, 1.1f, Position.z);
		}
	void OnMouseDown()   
	{
		Application.Quit ();
	}
}
