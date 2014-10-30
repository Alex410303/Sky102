using UnityEngine;
using System.Collections;
using System;

public class LampMove : MonoBehaviour 
{

	public float speed = 50 ;
	public bool MoveInLeft = true;
	public float dist = 3;
	float Range = 0;
	float StartPosi = 0;

	//float Vect = 1;


	// Update is called once per frame
	void Update ()
	{

		var Posi = gameObject.transform.position;
		if (Range == 0)
		{
			Range = Math.Min(Posi.y - dist,Posi.y + dist);
			StartPosi = Posi.y;
		}
		if (Posi.y > StartPosi) 
		{
			MoveInLeft = true;
			//gameObject.transform.Translate(Vector3.left * Time.deltaTime);
		}


		if (Math.Abs(Posi.y) > StartPosi - Range & MoveInLeft)

		{

			gameObject.transform.Translate(Vector3.left * Time.deltaTime * speed);

}
		else 
		{
			MoveInLeft = false;
			gameObject.transform.Translate(Vector3.right * Time.deltaTime * speed);
			//var Posi = gameObject.transform.position;

		}
		gameObject.light.intensity = gameObject.transform.position.y/2;

	}


}
