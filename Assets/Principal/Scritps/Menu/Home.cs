﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Home : MonoBehaviour {


	public void PlayMenu(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex - 1);
	}
}
