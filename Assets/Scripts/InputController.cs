using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    Transform cam;
    public Joystick joystickMove;
    public Joystick joystickGiro;
    public Transform player;
    public CharacterController controller;
    public float speed = 10f;
    public float x;
    public float y;
    public float z;
    Vector3 move;
    void Start()
    {
        cam = Camera.main.transform; 
    }
    void Move()
    {
        x = joystickMove.Horizontal + Input.GetAxis("Horizontal");
        z = joystickMove.Vertical + Input.GetAxis("Vertical");
        move = player.right * x + player.forward * z;
        controller.Move(move * speed * Time.deltaTime);
    }

    
    void Update()
    {
        Move();
    }
}
