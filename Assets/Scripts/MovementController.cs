using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public CharacterController controller;
    public float gravity = 9.8f;
    public float speed = 20f;
    private float dropVelocity = 0;
    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        //Permite mover elemento en el world space
        Vector3 movement = transform.right * horizontal + transform.forward * vertical;
        controller.Move(movement * speed * Time.deltaTime);
        if(controller.isGrounded)
        {
            dropVelocity = 0;
        } else
        {
            dropVelocity -= gravity * Time.deltaTime;
            controller.Move( new Vector3(0, dropVelocity, 0) ); 
        }
    }
}
