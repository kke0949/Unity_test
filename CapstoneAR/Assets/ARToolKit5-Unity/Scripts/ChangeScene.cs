﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void MarkMenu_change()
    {
        SceneManager.LoadScene("MarkScene");
    }

    public void ModelMenu_change()
    {
        SceneManager.LoadScene("ModelScene");
    }

    public void MainMenu_change()
    {
        SceneManager.LoadScene("MainMenuScene");
    }

    public void Run_change()
    {
        SceneManager.LoadScene("ARScene");
    }
}
