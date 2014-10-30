using UnityEngine;
using System.Collections;

public class GameEnd : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "lifePoint") 
		{
				
		}
		if (other.gameObject.tag == "MyPlayer") 
		{
			Destroy(other.gameObject);
		}
	}
}
