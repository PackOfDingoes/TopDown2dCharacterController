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
	private float moveTime;
	public float speed = 2f;
	private bool isMoving = false;

	void Awake ()
    {
//		rb2d = GetComponent<Rigidbody2D>();
		currentPos = this.transform.position;
	}

	void Update ()
    {
		Move();
	}

    void FixedUpdate ()
    {
		
    }

	void Move ()
	{
		moveTime += Time.deltaTime * speed;
		if (isMoving == false)
		{
			if (Input.GetButton("Right"))
			{
				oldPos = this.transform.position;
				nextPos = new Vector2(currentPos.x + 1.0f, currentPos.y);
				moveTime = 0f;
			}
			if (Input.GetButton("Left"))
			{
				oldPos = this.transform.position;
				nextPos = new Vector2(currentPos.x - 1.0f, currentPos.y);
				moveTime = 0f;
			}
			if (Input.GetButton("Up"))
			{
				oldPos = this.transform.position;
				nextPos = new Vector2(currentPos.x, currentPos.y + 1.0f);
				moveTime = 0f;
			}
			if (Input.GetButton("Down"))
			{
				oldPos = this.transform.position;
				nextPos = new Vector2(currentPos.x, currentPos.y - 1.0f);
				moveTime = 0f;
			}
		}

		currentPos = nextPos;

		this.transform.position = Vector2.Lerp(oldPos, nextPos, moveTime);

		if(this.transform.position.x == currentPos.x && this.transform.position.y == currentPos.y)
		{
			isMoving = false;
		}

		if(this.transform.position.x != currentPos.x || this.transform.position.y != currentPos.y)
		{
			isMoving = true;
		}
	}
}
