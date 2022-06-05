
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class girl_walk : MonoBehaviour
{
    // Start is called before the first frame update
    Animator animator;
    CharacterController charController;
    public float moveSpeed = 5f;//²¾°Ê³t«×
    public float gravity = 20.0F;  //­«¤O
    private Vector3 moveDirection = Vector3.zero;
    private Vector3 rotationDircetion;
    public float _rotationSpeed = 180;
    public GameObject girl;

    void Start()
    {
        animator = GetComponent<Animator>();
        charController = GetComponent<CharacterController>(); //§âCharacterController¸j¨ìcontroller
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey("down") || Input.GetKey("left") || Input.GetKey("right"))
        {
            //Debug.Log("front");
            animator.ResetTrigger("stand");
            animator.SetTrigger("walk_front");

        }
        else
        {
            animator.ResetTrigger("walk_front");
            animator.SetTrigger("stand");
        }
        if (Input.GetKey(KeyCode.Space))
        {
           
        }
        rotationDircetion = new Vector3(0, Input.GetAxisRaw("Horizontal") * _rotationSpeed * Time.deltaTime, 0);
        moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        moveDirection = transform.TransformDirection(moveDirection*6);
        moveDirection *= moveSpeed;
        moveDirection.y -= gravity * Time.deltaTime;
        charController.Move(moveDirection * Time.deltaTime);
        transform.Rotate(rotationDircetion);
    }
}

