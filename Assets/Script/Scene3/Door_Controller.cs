using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Controller : MonoBehaviour
{
    // Start is called before the first frame update
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.O))
        {
            animator.SetTrigger("open_door");
            Debug.Log("Open Door");
            animator.SetTrigger("opened");
            animator.ResetTrigger("close_door");
        }
        

        if (Input.GetKey(KeyCode.C))
        {
            animator.SetTrigger("close_door");
            Debug.Log("Close Door");
            animator.SetTrigger("closed");
            animator.ResetTrigger("open_door");
        }

    }
}
