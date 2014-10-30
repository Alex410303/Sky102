using UnityEngine;
using System.Collections;

public class Meteor : MonoBehaviour {

	// Use this for initialization
	float gg;
	void Start () {
		gg = Random.Range (-50, 50);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.forward * Time.deltaTime * gg);

	}
	void OnTriggerEnter2D(Collider2D other)
	{
		//var ee = new Global ();
		//ee.giveDemage (other, gameObject,50);
		//Destroy (other);
		//Application.Quit ();
		//Destroy (gameObject);
		//Destroy (other);
	}
}
