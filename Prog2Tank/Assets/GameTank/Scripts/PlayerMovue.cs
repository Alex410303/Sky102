using UnityEngine;
using System.Collections;

public class PlayerMovue : MonoBehaviour {

	public float SpeedPlayer = 5;

	void Update () 
	{
		int up = 0;
		int right = 0;

		//float moveW ="H");
		//float moveS = Input.GetAxis("s");
		//float moveA = Input.GetAxis("a");
		//float moveD = Input.GetAxis("d");

		if (Input.GetKey(KeyCode.W))
		{
			up = 1;
			//rigidbody2D.velocity = new Vector2( 0 ,SpeedPlayer);
		}
		if (Input.GetKey(KeyCode.S))
		{
			up = -1;
			//rigidbody2D.velocity = new Vector2( 0 ,-SpeedPlayer);
		}if (Input.GetKey(KeyCode.A))
		{
			right = -1;
			//rigidbody2D.velocity = new Vector2( -SpeedPlayer, 0 );
		}if (Input.GetKey(KeyCode.D))
		{
			right = 1;
			//rigidbody2D.velocity = new Vector2( SpeedPlayer, 0);
		}

		rigidbody2D.velocity = new Vector2( right*SpeedPlayer, up*SpeedPlayer);
//		rigidbody2D.velocity = new Vector2( 0 , moveW * SpeedPlayer);
//		rigidbody2D.velocity = new Vector2( 0 , -moveS * SpeedPlayer);
//		rigidbody2D.velocity = new Vector2( -moveA * SpeedPlayer , 0);
//		rigidbody2D.velocity = new Vector2( moveD * SpeedPlayer , 0);

	}
}
