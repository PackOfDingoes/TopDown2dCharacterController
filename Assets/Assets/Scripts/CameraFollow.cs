using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour 
{
	private GameObject player;
	private GameController gameController;

//	public float speed = 2f;
//	private Vector3 oldPos;
//	private float moveTime = 0f;

	private Rigidbody2D rb2d;

	void Start () 
	{
//		rb2d = this.GetComponent<Rigidbody2D>();
		player = GameObject.FindGameObjectWithTag("Player");
		gameController = GetComponent<GameController>();
//		oldPos = this.transform.position;
	}

	void Update () 
	{
		Move();
	}

	void Move ()
	{
		this.transform.position = new Vector3 (player.transform.position.x, player.transform.position.y, this.transform.position.z);

//		rb2d.velocity = player.transform.position * speed;

//		moveTime += Time.deltaTime * speed;
//
//		this.transform.position = Vector3.Lerp(new Vector3(oldPos.x, oldPos.y, this.transform.position.z), new Vector3(player.transform.position.x,player.transform.position.y, this.transform.position.z), moveTime);
//
//		if (rb2d.velocity.x > 0 && this.transform.position.x > player.transform.position.x)
//		{
//			rb2d.velocity = new Vector2(this.transform.position.x, player.transform.position.y) * speed;
//		}
//
//		if (rb2d.velocity.x < 0 && this.transform.position.x < player.transform.position.x)
//		{
//			rb2d.velocity = new Vector2(-this.transform.position.x, player.transform.position.y) * speed;
//		}
//
//		if (rb2d.velocity.y > 0 && this.transform.position.y > player.transform.position.y)
//		{
//			rb2d.velocity = new Vector2(this.transform.position.y, player.transform.position.x) * speed;
//		}
//
//		if (rb2d.velocity.y < 0 && this.transform.position.y < player.transform.position.y)
//		{
//			rb2d.velocity = new Vector2(this.transform.position.y, -player.transform.position.x) * speed;
//		}
	}
}
