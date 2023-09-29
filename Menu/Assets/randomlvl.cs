using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class randomlvl : MonoBehaviour
{
    public int levelGenerate;

    public void loadthelevel()
    { levelGenerate = Random.Range(0, 4); }

    private void OnTriggerEnter(Collider other)
    {
    
        if (other.gameObject.name == "FreeZombie")
        {
            SceneManager.LoadScene(levelGenerate);
        }
    }
}
