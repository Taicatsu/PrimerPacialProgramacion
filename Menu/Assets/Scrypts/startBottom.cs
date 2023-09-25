using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startBottom : MonoBehaviour
{
    public void Iniciarjuego()
      
    {
        SceneManager.LoadScene("Ciudad");
    }
     public void Escape()
    {
        Application.Quit();

    }

    }
