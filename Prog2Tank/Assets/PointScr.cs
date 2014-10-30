using UnityEngine;
using System.Collections;

public class PointScr : MonoBehaviour {
	
	public int speedM = 10;
	bool gameSt = true; 

	void Update () 
	{
	
		if (gameSt == false)
		{
			//var TextEndGame =  new GameObject.
			Time.timeScale = 0;	
		}

	}
	void OnTriggerEnter2D(Collider2D other)
	{

		float Moves = 0;

		if (other.gameObject.tag == "bul1") 
		{
			Moves = 1f;

		}
		if (other.gameObject.tag == "bul2") 
		{
			Moves = -1f;
		}
		Debug.Log (""+Moves);

		if (other.tag != "finishLine") 
		{
			rigidbody2D.AddForce(new Vector2( Moves*speedM, Moves*speedM));		
			Destroy (other.gameObject);
		} 
		else 
		{
			gameSt = false;

		}

	}
}
