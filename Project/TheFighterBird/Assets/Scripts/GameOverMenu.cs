﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    public void TryAgain()
    {
        SceneManager.LoadScene(1);
    }
    public void GoToMain()
    {
        SceneManager.LoadScene(0);
    }
}
