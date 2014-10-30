using UnityEngine;
using System.Collections;

public class BullTowerD : MonoBehaviour {

	void Start () 
	{
		Destroy (gameObject,6);
	}

	void Update ()
	{
		
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.name == "Player2")// && (other.gameObject.name == "Player")) 
		{
			Destroy(other.gameObject);
			Destroy(gameObject);
	
		}
		if (other.gameObject.name == "Player")
		{
			Destroy(other.gameObject);
			Destroy(gameObject);
		}

	}
}
