using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemy : MonoBehaviour
{
    public int Respawn;



    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "FreeZombie")
        { SceneManager.LoadScene(Respawn); }
    
    }

}
