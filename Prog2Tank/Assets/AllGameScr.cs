using UnityEngine;
using System.Collections;

public class AllGameScr : MonoBehaviour {

	public Rigidbody2D player;
	public Rigidbody2D player2;

	float cooldown;

	public Rigidbody2D TowerDWBullet;
	public Rigidbody2D Tower;
	GameObject TowerDw;
	float CDtimeT1;
	float CDtimeT2;
	public int restorTower;
	public float SpeedTDwBull;

	void Start () 
	{
		TowerDw = GameObject.Find ("TowerDw");
	}

	
	//var TargetTank = GameObject.FindWithTag("Enemy");
	//var positionTargetTank = TargetTank.transform.position;
	//var MyPosition = gameObject.transform.position;
	// Update is called once per frame
	void Update () 
	{

		var Player1 = GameObject.Find("Player");
		var Player2 = GameObject.Find("Player2");

		if (Player1 == null)
		{
			var RespP1 = GameObject.Find("RespP1");
			var posRespP1 = RespP1.transform.position;		
			Rigidbody2D newPlayer = Instantiate (player, posRespP1, Quaternion.identity) as Rigidbody2D;
			newPlayer.name = "Player";
			newPlayer.tag = "MyPlayer";

		}
		if (Player2 == null)
		{
			var RespP1 = GameObject.Find("RespP2");
			var posRespP1 = RespP1.transform.position;
			Rigidbody2D newPlayer2 = Instantiate (player2, posRespP1, Quaternion.identity) as Rigidbody2D;
			newPlayer2.name = "Player2";
			newPlayer2.tag = "MyPlayer2";
		}
		 
//		if (Time.time >= CDtimeT1)
//			{
//	
//			Rigidbody2D Prefab = Instantiate (Tower, TowerDw.transform.position, Quaternion.identity) as Rigidbody2D;
//				var PosP2 = Player2.transform.position;
//				Prefab.AddForce((PosP2 - TowerDw.transform.position)*SpeedTDwBull);
//			CDtimeT1 = Time.time + restorTower;
//			}
//		if (Time.time >= CDtimeT2)
//		{
//
//			Rigidbody2D Prefab = Instantiate (Tower, TowerDw.transform.position, Quaternion.identity) as Rigidbody2D;
//			var PosP2 = Player2.transform.position;
//			Prefab.AddForce((PosP2 - TowerDw.transform.position)*SpeedTDwBull);
//			CDtimeT2 = Time.time + restorTower;
//		}


	}
}
