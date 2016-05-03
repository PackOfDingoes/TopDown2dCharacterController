using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class PlayerController: MonoBehaviour
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

    public int currentHP;
    private int maxHP;

    public int currentLvl = 1;
    public float expTotal = 0f;
    public float expToNextLvl = 100;
    private int expSinceLevel = 0;
    public float expModMod = 0.9f;
    public float expModToNextLvl = 1f;

    public Dictionary<string, int> attributes = new Dictionary<string, int>();
    public string[] stats = new string[6] { "str", "dex", "con", "int", "wis", "cha" };

	void Awake ()
    {
		collisionChecker = collisionCheckerObject.GetComponent<CollisionChecker>();
		currentPos = this.transform.position;
        StatStart();
    }

    void Start ()
    {

    }

	void Update ()
    {
        if (Input.GetKeyDown("1"))
        {
            ExperienceChange(110);
        }
	}

    void FixedUpdate ()
    {
		Move();
    }

    void StatStart()
    {
        for (int i = 0; i < stats.Length; i++)
        {
            attributes.Add(stats[i], 8);
        }

        maxHP = attributes["con"] * 2;
        currentHP = maxHP;
    }

    public void ExperienceChange(int change)
    {
        expTotal += change;
        expSinceLevel += change;

        if (expSinceLevel >= expToNextLvl)
        {
            LevelUp(expSinceLevel - Convert.ToInt16(expToNextLvl));
        }

        Debug.Log("Level: " + currentLvl + "\n Exp Total: " + expTotal);
        Debug.Log("Exp until Lvl " + (currentLvl + 1) + " " + expSinceLevel + "/" + expToNextLvl);
    }

    public void LevelUp(int remainingExp = 0)
    {
        currentLvl++;
        expSinceLevel = 0 + remainingExp;
        expModToNextLvl = expModToNextLvl * expModMod;
        expToNextLvl = expToNextLvl * (1+expModToNextLvl);
        expToNextLvl = Convert.ToInt16(expToNextLvl);
    }

    public void StatChange(string statToChange = null, int changeAmount = 0)
    {
        if (statToChange != null)
        {
            attributes[statToChange] += changeAmount;
        }
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
