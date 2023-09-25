using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tercerapersona : MonoBehaviour
{


    public CharacterController controller;
 

        public float speed = 6f;

    public float turnSmoothTime = 0.1f;

    float turnsmoothvelocity;


    void Start()
    {
        
    }

    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if(direction.magnitude >= 0.1f) 
        {

            float targetangle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetangle, ref turnsmoothvelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            
        controller.Move(direction * speed * Time.deltaTime);
        }
    }
}
