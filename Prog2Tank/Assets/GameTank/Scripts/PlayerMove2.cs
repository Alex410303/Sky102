using UnityEngine;
using System.Collections;

public class PlayerMove2 : MonoBehaviour {

	public float SpeedPlayer = 5;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		int up = 0;
		int right = 0;

		if (Input.GetKey(KeyCode.UpArrow))
		{
			up = 1;
			//rigidbody2D.velocity = new Vector2( 0 ,SpeedPlayer);
		}
		if (Input.GetKey(KeyCode.DownArrow))
		{
			up = -1;
			//rigidbody2D.velocity = new Vector2( 0 ,-SpeedPlayer);
		}if (Input.GetKey(KeyCode.LeftArrow))
		{
			right = -1;
			//rigidbody2D.velocity = new Vector2( -SpeedPlayer, 0 );
		}if (Input.GetKey(KeyCode.RightArrow))
		{
			right = 1;
			//rigidbody2D.velocity = new Vector2( SpeedPlayer, 0);
		}
		
		rigidbody2D.velocity = new Vector2( right*SpeedPlayer, up*SpeedPlayer);
//		float moveX = Input.GetAxis("Horizontal");
//		float moveY = Input.GetAxis("Vertical");
//		
//		rigidbody2D.velocity = new Vector2( moveX * 5 , moveY * 5);
	}
}
