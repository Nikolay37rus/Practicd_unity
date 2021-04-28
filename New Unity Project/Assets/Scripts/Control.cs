using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
   [SerializeField]
    private float speedMove;
    [SerializeField]
    private float jumpPowe;

    [SerializeField]
    private float gravityForce;
    [SerializeField]
    private Vector3 moveVector;


    [SerializeField]
    private CharacterController _controller;
    [SerializeField]
    private Animator _animator;

    private void Start()
    {
        _controller = GetComponent<CharacterController>();
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        CharacterMove();
        GamingGraviti();
    }


    
    private void CharacterMove()
    {
        
        moveVector = Vector3.zero;
        moveVector.x = Input.GetAxis("Horizontal") * speedMove;
        moveVector.z = Input.GetAxis("Vertical") * speedMove;

        if(Vector3.Angle(Vector3.forward,moveVector)>1f || Vector3.Angle(Vector3.forward, moveVector) ==0)
        {
            Vector3 direction = Vector3.RotateTowards(transform.forward, moveVector, speedMove, 0.0f);
            transform.rotation = Quaternion.LookRotation(direction);
        }

        moveVector.y = gravityForce;
        _controller.Move(moveVector * Time.deltaTime);
    }

    

    private void GamingGraviti()
    {
        if (!_controller.isGrounded) gravityForce -= 20f * Time.deltaTime;
        else gravityForce = -1f;
        if (Input.GetKeyDown(KeyCode.Space) && _controller.isGrounded) gravityForce = jumpPowe;
    }





}
