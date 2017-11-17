﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayRestartText : MonoBehaviour {
    private Texture2D t2D; //reference to actual text
	// Use this for initialization
	void Start () {
        t2D = Resources.Load<Texture2D>("restart-text");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnGUI()
    {
        //calculate center position 
        var x = (Screen.width - t2D.width) / 2;
        var y = Screen.height - 50;

        if(Time.time % 2 > 1)
        GUI.DrawTexture(new Rect(x, y, t2D.width, t2D.height), t2D);
    }
}
