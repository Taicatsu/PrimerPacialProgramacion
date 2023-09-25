using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombieScript : MonoBehaviour
{
    public Animator zombieAnimator;

    public float velocity;

    public PauseMenu pauseMenu;



    public void Update()
    {

        if (!pauseMenu.isPaused)
        {




            if (Input.GetKey(KeyCode.W))
            {
                zombieAnimator.SetFloat("MoveSpeed", 10);  //getkeydown=clickear keycode=asignar tecla getkey=mantener
                transform.position += transform.forward * Time.deltaTime * 100;
            }
            else if (Input.GetKeyUp(KeyCode.W)) { zombieAnimator.SetFloat("MoveSpeed", 0); }  //getkeyup=soltar  

            if (Input.GetKey(KeyCode.S))
            {
                zombieAnimator.SetFloat("MoveSpeed", 10);
                transform.position -= transform.forward * Time.deltaTime * 100;
            }
            if (Input.GetKeyUp(KeyCode.S)) { zombieAnimator.SetFloat("MoveSpeed", 0); }


            if (Input.GetKey(KeyCode.A))
            {
                zombieAnimator.SetFloat("MoveSpeed", 10);
                transform.position -= transform.right * Time.deltaTime * 100;
            }
            if (Input.GetKeyUp(KeyCode.A)) { zombieAnimator.SetFloat("MoveSpeed", 0); }

            if (Input.GetKey(KeyCode.D))
            {
                zombieAnimator.SetFloat("MoveSpeed", 10);
                transform.position += transform.right * Time.deltaTime * 100;
            }
            if (Input.GetKeyUp(KeyCode.D)) { zombieAnimator.SetFloat("MoveSpeed", 0); }


        }

    }










}
