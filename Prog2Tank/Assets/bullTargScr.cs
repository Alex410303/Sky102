using UnityEngine;
using System.Collections;

public class bullTargScr : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Destroy (gameObject,4);
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		//Debug.Log(""+other.gameObject.tag);
		if (other.gameObject.tag == "MyPlayer")
		{
			Destroy(other.gameObject);
			//Debug.Log(""+gameObject.);
		}
	}
}
