﻿using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour {

    public Transform player;
    public Text scoreText;
	
	void Update () {
        scoreText.text = (player.position.z + 45).ToString("0"); // ToString() to display exact float number, ToString("0") to display without floating point
	}
}
