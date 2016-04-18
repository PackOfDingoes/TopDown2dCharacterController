using UnityEngine;
using System.Collections;

public class CollisionChecker : MonoBehaviour 
{
	public bool isColliding = false;
	public string ObstacleTag = "Obstacle";

	void Start () 
	{
	
	}

	void Update () 
	{
	
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.tag == ObstacleTag)
		{
			isColliding = true;
		}
	}
}
