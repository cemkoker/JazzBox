﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class Screenshotter : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.P)) {
			string datetime = DateTime.Now.ToString();
			datetime = datetime.Replace("/", "");
			datetime = datetime.Replace(" ", "");
			datetime = datetime.Replace(":", "");

			

			
			string filename = "screenshot_"+datetime+".png";

			string path = Application.dataPath;
			if (Application.platform == RuntimePlatform.OSXPlayer) {
				path += "/../../";
			}
			else if (Application.platform == RuntimePlatform.WindowsPlayer) {
				path += "/../";
			}
			else if (Application.platform == RuntimePlatform.OSXEditor) {
				path += "/../";
			}
			path += "Screenshots/";
			if (!Directory.Exists(path)) {
				Directory.CreateDirectory(path);
			}
			path += filename;

			Debug.Log(path);

			ScreenCapture.CaptureScreenshot(path, 3);
		}	
	}
}
