﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartTest : MonoBehaviour {

	public void restart() {
		SceneManager.LoadScene("test");
	}
}
