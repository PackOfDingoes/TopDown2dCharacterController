using UnityEngine;
using System;
using UnityEngine.UI;
using System.Collections;

public class GameController : MonoBehaviour 
{

	public bool cameraFollowPlayer = false;

	private PlayerController playerCont;

	private Canvas canvasUI;

	void Awake ()
	{
		FindPlayer();
		canvasUI = GameObject.Find("UI").GetComponent<Canvas>();
		canvasUI.worldCamera = this.gameObject.GetComponent<Camera>();
	}

	void Start () 
	{
	
	}

	void Update () 	
	{
		
	}
		

	public void FindPlayer()
	{
		playerCont = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
	}
}
