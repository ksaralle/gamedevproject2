﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deployfish : MonoBehaviour
{
	
	public GameObject fishPrefab;
	public float respawnTime = 3.0f;
	private Vector2 screenBounds;
	// Start is called before the first frame update
	void Start()
	{
		screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
		StartCoroutine(fishWave());
	}

	private void spawnFish()
	{
		
		Instantiate(fishPrefab);
	}

	IEnumerator fishWave()
	{
		while (true)
		{
			yield return new WaitForSeconds(respawnTime);
			spawnFish();
		}

	}


}
