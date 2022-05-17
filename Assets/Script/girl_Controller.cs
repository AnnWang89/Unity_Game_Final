using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class girl_Controller : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject girl;
    public float moveSpeed = 5f;//移動速度
    public float jumpSpeed = 8.0F; //起跳距離
    public float gravity = 20.0F;  //重力
    public float moveSpeedDefault = 10.0F;  //重力
    public float moveSpeedUP = 20.0F;  //重力
    private Vector3 moveDirection = Vector3.zero;
    CharacterController girlController;


    // Start is called before the first frame update
    void Start()
    {
        girlController = GetComponent<CharacterController>(); //把CharacterController綁到controller
    }

    // Update is called once per frame
    void Update()
    {
        //move();
        if (girlController.isGrounded) //如果在地板，才可控制
        {
            //獲得Horizontal軸 在-1到1中間浮動 A D 左右，W S 前 後
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= moveSpeed;
            if (Input.GetButton("Jump"))
            { moveDirection.y = jumpSpeed; }

        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            moveSpeed = moveSpeedUP;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            moveSpeed = moveSpeedDefault;
        }
        moveDirection.y -= gravity * Time.deltaTime;
        girlController.Move(moveDirection * Time.deltaTime);

    }
}
