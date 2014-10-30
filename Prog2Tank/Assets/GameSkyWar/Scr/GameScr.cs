using UnityEngine;
using System.Collections;



public class Global
{
	public static class rocked
	{
		public static string namev;
		public static float demage;
		public static float speed;
		public static float radiusShut;
		public static float radiusDem;
			
	}
	
	////public void giveDemage (GameObject d ,GameObject b, float tr) 
	//{
		//GameObject.
		//Debug.Log ("" + d + "   " + b);
	//}

	//void rockedstandart ()
	
}

public class kk
{
	public  Rigidbody2D RBk;
	public  Rigidbody2D Rigidbody2DRocked;

	public  Vector3 trk;

	//public static class rocked
	//{		
	public  string namev;
	public  float demage;
	public  float speed;
	public  float radiusShut;
	public  float radiusDem;
	public  Vector2 adfors;
	public  float gradzR;

	//}
	public void newUnit ()
	{
		Debug.Log ("rrr "+gradzR);
		Rigidbody2D Rigidbody2DRocked = GameObject.Instantiate (RBk ,trk, Quaternion.identity) as Rigidbody2D;
		Rigidbody2DRocked.transform.Rotate (0, 0, gradzR);
		Rigidbody2DRocked.AddRelativeForce (new Vector2(0,1)*speed);

	}

	public void Push ()
	{


		//Rigidbody2DRocked.AddRelativeForce (Adfors);
		//Debug.Log ("gggg");
		//Rigidbody2D eee = GameObject.Instantiate (RBk ,trk, Quaternion.identity) as Rigidbody2D;
		
	}

	
}

public class GameScr : MonoBehaviour {
	 
	public bool GameStart = true;
	public Rigidbody2D bonus;
	public Rigidbody2D meteor;
	float cdDie;

	public float cdDcrMeteor = 1;
	public float speedteor = 2;

	float cdBon;	
	public float cdBonSec = 5;


	void Start ()
	{
		cdDie = Time.time + cdDcrMeteor;
		cdBon = Time.time + cdBonSec;

	}
	
	void Update () {
		if (Time.time >= cdDie) {
			Rigidbody2D meteorRb = Instantiate (meteor ,new Vector3((float)Random.Range(-5,5),(float)Random.Range(-5,5),0), Quaternion.identity) as Rigidbody2D;
			meteorRb.AddForce(new Vector2((float)Random.Range(-5,5),(float)Random.Range(-5,5))*speedteor);
			meteorRb.transform.Rotate(0,0,(float)Random.Range(-180,180));

			meteorRb.gameObject.name = "meteor";
			cdDie = Time.time + cdDcrMeteor;
		
		}
		if (Time.time >= cdBon) {
			Rigidbody2D bonusRb = Instantiate (bonus ,new Vector3((float)Random.Range(-5,5),(float)Random.Range(-5,5),0), Quaternion.identity) as Rigidbody2D;
			bonusRb.gameObject.name = "bonus";
			bonusRb.AddForce(new Vector2((float)Random.Range(-5,5),(float)Random.Range(-5,5)));
			bonusRb.transform.Rotate(0,0,(float)Random.Range(-180,180));
			cdBon = Time.time + cdBonSec;
			
		}


	}

	public float xMargin = 1f;        // Distance in the x axis the player can move before the camera follows.
	public float yMargin = 1f;        // Distance in the y axis the player can move before the camera follows.
	public float xSmooth = 8f;        // How smoothly the camera catches up with it's target movement in the x axis.
	public float ySmooth = 8f;        // How smoothly the camera catches up with it's target movement in the y axis.
	public Vector2 maxXAndY;        // The maximum x and y coordinates the camera can have.
	public Vector2 minXAndY;        // The minimum x and y coordinates the camera can have.
	
	
	private Transform player;        // Reference to the player's transform.
	
	
	void Awake ()
	{
		// Setting up the reference.
		player = GameObject.Find("Char1").transform;
	}
	
	
	bool CheckXMargin()
	{
		// Returns true if the distance between the camera and the player in the x axis is greater than the x margin.
		return Mathf.Abs(transform.position.x - player.position.x) > xMargin;
	}
	
	
	bool CheckYMargin()
	{
		// Returns true if the distance between the camera and the player in the y axis is greater than the y margin.
		return Mathf.Abs(transform.position.y - player.position.y) > yMargin;
	}
	
	
	void FixedUpdate ()
	{
		TrackPlayer();
	}
	
	
	void TrackPlayer ()
	{
		// By default the target x and y coordinates of the camera are it's current x and y coordinates.
		float targetX = transform.position.x;
		float targetY = transform.position.y;
		
		// If the player has moved beyond the x margin...
		if(CheckXMargin())
			// ... the target x coordinate should be a Lerp between the camera's current x position and the player's current x position.
			targetX = Mathf.Lerp(transform.position.x, player.position.x, xSmooth * Time.deltaTime);
		
		// If the player has moved beyond the y margin...
		if(CheckYMargin())
			// ... the target y coordinate should be a Lerp between the camera's current y position and the player's current y position.
			targetY = Mathf.Lerp(transform.position.y, player.position.y, ySmooth * Time.deltaTime);
		
		// The target x and y coordinates should not be larger than the maximum or smaller than the minimum.
		targetX = Mathf.Clamp(targetX, minXAndY.x, maxXAndY.x);
		targetY = Mathf.Clamp(targetY, minXAndY.y, maxXAndY.y);
		
		// Set the camera's position to the target position with the same z component.
		transform.position = new Vector3(targetX, targetY, transform.position.z);
	}





}
