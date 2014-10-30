using UnityEngine;
using System.Collections;

public class FireTarg : MonoBehaviour {
	
	public Rigidbody2D buletPrefab;
	public float AtSpeed = 0.5f;
	public float coolDown;
	
	// Update is called once per frame
	void Update () 
	{
		
		if (Time.time >= coolDown) 
		{
				//var objectList = GameObject.FindGameObjectsWithTag("Enemy");
				//foreach (var GObj in objectList)
				//{
				
				//}  
				//Fire();
		}
	}
	
	void Fire()
	{

		var TargetTank = GameObject.FindWithTag("MyPlayer");
		var positionTargetTank = TargetTank.transform.position;
		var MyPosition = gameObject.transform.position;

		Rigidbody2D Prefab = Instantiate (buletPrefab, transform.position, Quaternion.identity) as Rigidbody2D;
		
		Prefab.rigidbody2D.AddForce((positionTargetTank - MyPosition)*20);
		coolDown = Time.time + AtSpeed;


		//float up = Random.Range(-10,10);
		//float dw = Random.Range(-10,10);
		//Rigidbody2D Prefab = Instantiate (buletPrefab, transform.position, Quaternion.identity) as Rigidbody2D;
		//Prefab.rigidbody2D.AddForce( new Vector2 (up*40,dw*40));
		//Prefab.rigidbody2D.AddForce(Vector3.up *500);
		//coolDown = Time.time + AtSpeed;
	}
}
