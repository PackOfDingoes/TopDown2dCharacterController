using UnityEngine;
using System.Collections;

public class TopDown2DCharacterController : MonoBehaviour
{
//	private Rigidbody2D rb2d;

//	movement and lerps and shit, can probably skip a step here if I wasn't bad
//	>>>>>>>>> M A K E  B E T T E R <<<<<<<<<<
	private Vector2 oldPos;
	private Vector2 currentPos;
	private Vector2 nextPos;
	public GameObject collisionCheckerObject;
	private CollisionChecker collisionChecker;
	private float moveTime;
	public string ObstacleTag = "Obstacle";
	public float gridSize = 1.0f;
	public float speed = 2f;
	private bool isMoving = false;
	private bool canMove = true;

	void Awake ()
    {
//		rb2d = GetComponent<Rigidbody2D>();
		collisionChecker = collisionCheckerObject.GetComponent<CollisionChecker>();
		currentPos = this.transform.position;
	}

	void Update ()
    {
		
	}

    void FixedUpdate ()
    {
		Move();
    }

	void Move ()
	{
		moveTime += Time.deltaTime * speed;
		if (isMoving == false)
		{
			if (Input.GetButton("Right"))
			{
				MoveDirection("right");
			}
			if (Input.GetButton("Left"))
			{
				MoveDirection("left");
			}
			if (Input.GetButton("Up"))
			{
				MoveDirection("up");
			}
			if (Input.GetButton("Down"))
			{
				MoveDirection("down");
			}
		}
			
		if(collisionChecker.isColliding == false)
		{
			currentPos = nextPos;

			this.transform.position = Vector2.Lerp(oldPos, nextPos, moveTime);
		}

		if(collisionChecker.isColliding == true)
		{
			nextPos = oldPos;
			currentPos = oldPos;
			collisionChecker.isColliding = false;
		}

		collisionCheckerObject.transform.position = currentPos;

		if(this.transform.position.x == currentPos.x && this.transform.position.y == currentPos.y)
		{
			isMoving = false;
		}

		if(this.transform.position.x != currentPos.x || this.transform.position.y != currentPos.y)
		{
			isMoving = true;
		}
	}

	void MoveDirection(string direction)
	{
		oldPos = this.transform.position;
		switch (direction)
		{
			case "right":
				nextPos = new Vector2(currentPos.x + gridSize, currentPos.y);
				break;
			case "left":
				nextPos = new Vector2(currentPos.x - gridSize, currentPos.y);
				break;
			case "up":
				nextPos = new Vector2(currentPos.x, currentPos.y + gridSize);
				break;
			case "down":
				nextPos = new Vector2(currentPos.x, currentPos.y - gridSize);
				break;
			default:
				nextPos = currentPos;
				break;
		}
		collisionCheckerObject.transform.position = nextPos;
		moveTime = 0f;
	}
}
