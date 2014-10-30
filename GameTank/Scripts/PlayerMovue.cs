using UnityEngine;
using System.Collections;

public class PlayerMovue : MonoBehaviour {

	public float SpeedPlayer = 5;

	// Update is called once per frame
	void Update () 
	{
		float moveX = Input.GetAxis("Horizontal");
		float moveY = Input.GetAxis("Vertical");
		 
		 rigidbody2D.velocity = new Vector2( moveX * SpeedPlayer , moveY * SpeedPlayer);

	}
}
