using UnityEngine;
using System.Collections;

public class BullScr2 : MonoBehaviour 
{
	
	float latenc;
	float cd = 0.7f;
	bool imp = false;
	// Use this for initialization
	void Start () 
	{
		Destroy (gameObject,4);
		//latenc = Time.time + cd;		
	}
	
	void Update () 
	{
	}
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "lifePoint") 
		{
			//Destroy(gameObject);		
		}
		if (other.gameObject.tag == "MyPlayer") 
		{
			Destroy(other.gameObject);
		}
	}
}
