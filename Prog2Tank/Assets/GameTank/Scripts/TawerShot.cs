using UnityEngine;
using System.Collections;
using System;

public class TawerShot : MonoBehaviour {

	public Rigidbody2D TowerBullet;
	public float CDtimeTwDwBullet;
	float CDtime;
	public float SpeedTDwBull;
	public string nameTarg; 

	void Update () 
	{
	
		if (Time.time >= CDtime)
		{
			
			GameObject PlayerShooting = GameObject.Find (nameTarg);
			Rigidbody2D Prefab = Instantiate (TowerBullet, transform.position, Quaternion.identity) as Rigidbody2D;
			var PosP2 = PlayerShooting.transform.position;
			Prefab.name = "TowerBull";
			var rezVect = PosP2 - transform.position;
			double L = Math.Sqrt((rezVect.x*rezVect.x + rezVect.y*rezVect.y));
			float rezX = (float)(rezVect.x/L);
			float rezY = (float)(rezVect.y/L);

			Prefab.AddRelativeForce(new Vector2(rezX,rezY)*SpeedTDwBull);
			Prefab.AddTorque(4);
			CDtime = Time.time + CDtimeTwDwBullet;

		}
	
	}
	
	void OnTriggerEnter2D(Collider2D other)
	{

		if (other.name != "TowerBull") 
		{
			Destroy (gameObject);
		}
	}
}
