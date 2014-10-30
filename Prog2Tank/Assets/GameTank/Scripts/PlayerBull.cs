using UnityEngine;
using System.Collections;
using System;

public class PlayerBull : MonoBehaviour 
{
	public Rigidbody2D buletPrefab;
	public float cdBul = 0.5f;
	public float speedBull = 500;
	float coolDown;
	float coolDownAmmor;

	public int ammor = 1;

	void Start () 
	{
		if (speedBull == 0) 
		{
			speedBull = 500;	
		}
	}

	// Update is called once per frame
	void Update () 
	{

		if (Time.time >= coolDownAmmor) 
		{
			ammor = ammor +1;
			coolDownAmmor = Time.time + cdBul;
		}

		if (Time.time >= coolDown & ammor > 0 ) 
		{
			
			//if (Input.GetKey(KeyCode.Space))
			//{
				
				var lifePoint = GameObject.FindWithTag("lifePoint");
			var Player1 = GameObject.FindWithTag("MyPlayer2");
				var TowerS = GameObject.FindGameObjectsWithTag("Tower");
				GameObject TowerF;								
				float distTowerDw = 6;
				
				var posTower = gameObject.transform.position;
				
				var MyPosition = gameObject.transform.position;
				var poslifePoint = lifePoint.transform.position;
				var posPlayer1 = Player1.transform.position;
		
				float distPlay = Vector2.Distance(posPlayer1, MyPosition);
				float distPoint = Vector2.Distance(poslifePoint, MyPosition);
				float minRange = Math.Min(distPlay,distPoint);
				
				foreach (GameObject Tower in TowerS)
				{					
				float distTower = Vector2.Distance(Tower.transform.position, MyPosition);
				if (distTower < distTowerDw)						
				{
				TowerF = Tower;
				posTower = Tower.transform.position;
				distTowerDw = distTower;
				minRange = Math.Min(Math.Min(distPlay,distPoint),distTower);
				}
				}
				
				if ( minRange  < 5 )			
				{
					
				var rezVect = posTower;

				Rigidbody2D Prefab = Instantiate (buletPrefab, transform.position, Quaternion.identity) as Rigidbody2D;
				if (minRange == distPlay)
				{
				rezVect = (posPlayer1 - MyPosition);
				}
				if (minRange == distPoint)
				{
				rezVect = (poslifePoint - MyPosition);
				}
				if (minRange == distTowerDw)
				{
				rezVect = (posTower - MyPosition);
				}	

				double L = Math.Sqrt((rezVect.x*rezVect.x + rezVect.y*rezVect.y));
				float rezX = (float)(rezVect.x/L);
				float rezY = (float)(rezVect.y/L);
				Prefab.rigidbody2D.AddRelativeForce(new Vector2(rezX,rezY)*speedBull);
				coolDown = Time.time + cdBul;
				ammor = ammor -1;
				}
			//}
		}

//		if (Time.time >= coolDown & ammor > 0 ) 
//		{
//
//			if (Input.GetKey(KeyCode.Space))
//			{
//				var lifePoint = GameObject.FindWithTag("lifePoint");
//				var Player2 = GameObject.FindWithTag("MyPlayer2");
//				
//				var poslifePoint = lifePoint.transform.position;
//				var posPlayer2 = Player2.transform.position;
//				
//				var MyPosition = gameObject.transform.position;
//				bool Player2Clos;
//				double distPlay = Vector2.Distance(posPlayer2, MyPosition);
//				double distPoint = Vector2.Distance(poslifePoint, MyPosition);
//				Player2Clos = distPlay < distPoint;
//				
//				if ( Math.Min(distPlay,distPoint)  < 5 )
//				{
//
//					
//					Rigidbody2D Prefab = Instantiate (buletPrefab, transform.position, Quaternion.identity) as Rigidbody2D;
//					if (Player2Clos == true)
//					{
//						Prefab.rigidbody2D.AddForce((posPlayer2 - MyPosition)*30);
//					}
//					else 
//					{
//						Prefab.rigidbody2D.AddForce((poslifePoint - MyPosition)*30);
//					}
//					
//					coolDown = Time.time + cdBul;
//					ammor = ammor -1;
//				}
//			}
//		}
	}

}
