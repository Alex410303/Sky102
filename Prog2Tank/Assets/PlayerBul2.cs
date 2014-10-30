using UnityEngine;
using System.Collections;

public class PlayerBul2 : MonoBehaviour {

	public Rigidbody2D buletPrefab;
	public float AtSpeed = 0.5f;
	public float coolDown;
	public float coolDownAmmor;
	
	public int ammor = 1;
	
	// Update is called once per frame
	void Update () 
	{
		
		if (Time.time >= coolDownAmmor) 
		{
			ammor = ammor +1;
			coolDownAmmor = Time.time + 3f;
		}
		
		if (Time.time >= coolDown & ammor > 0 ) 
		{
			
			if (Input.GetKey(KeyCode.Space))
			{
				
				var lifePoint = GameObject.FindWithTag("Enemy");
				var positionlifePoint = lifePoint.transform.position;
				var MyPosition = gameObject.transform.position;
				
				if ( Vector2.Distance(positionlifePoint,MyPosition)  < 5 )
				{				
				Rigidbody2D Prefab = Instantiate (buletPrefab, transform.position, Quaternion.identity) as Rigidbody2D;
				
				//Prefab.rigidbody2D.AddForce((positionTargetTank - MyPosition)*(-6));
				Prefab.rigidbody2D.AddForce((positionlifePoint - MyPosition) * 30);
				Destroy(Prefab,3);
				coolDown = Time.time + AtSpeed;
				ammor = ammor -1;
				}
			}
		}
	}

}
