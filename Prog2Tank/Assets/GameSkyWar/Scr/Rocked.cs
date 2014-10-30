using UnityEngine;
using System.Collections;

public class Rocked : MonoBehaviour {


	public int life = 100;

	void Start () 
	{
		//rigidbody2D.AddRelativeForce (new Vector2(0,1)*100);
		//AddRelativeForce (new Vector2 (0, 1) * SpeedMove);

		//Destroy (gameObject,5);
		//transform.Rotate (0,0,transform.parent.transform.rotation.z);
			//rigidbody2D.transform.Rotate (0, 0, transform.position.z+right);
		//GameObject kkk = transform.parent.transform.rotation.z;
		//Debug.Log ("m "+transform.rotation.z);
		//Debug.Log ("l "+transform.localPosition);
	}
	void Update ()
	{

	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.name != "Char1")
		{
			Destroy (other.gameObject);
			Destroy(gameObject);
		}

	}
}
