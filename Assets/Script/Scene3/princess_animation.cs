using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;
public class princess_animation : MonoBehaviour
{
    // Start is called before the first frame update
    Animator animator;
    public TextMeshPro angry_text;
    public GameObject boomerang;
    private Vector3 rotationDircetion;
    private Vector3 Dircetion;
    bool wake = false;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(angry_text.text == "NO!!")
        {
            if (!wake)
            {
                rotationDircetion = new Vector3(70, 0, 0);
                Dircetion = new Vector3(0, -1, -1);
                transform.Rotate(rotationDircetion);
                transform.TransformDirection(Dircetion);
                wake = true;
                boomerang.SetActive(true);
            }
            animator.SetTrigger("attack");
            StartCoroutine(Wait());
           
            //
            //animator.SetTrigger("damage");
            //animator.SetTrigger("origin");

        }
        if (angry_text.text == "I want my boomerang!!")
        {
            animator.SetTrigger("damage");
            StartCoroutine(Wait());
        }
        if (angry_text.text == "YA!!")
        {
            animator.SetTrigger("jump");
            StartCoroutine(Wait());
        }
        if (angry_text.text == "THANK YOU!!")
        {
            animator.SetTrigger("jump");
            
            StartCoroutine(Wait());
            
        }

    }
    IEnumerator Wait()
    {
        Debug.Log("Waiting");

        yield return new WaitForSeconds(2.5f);
        animator.ResetTrigger("attack");
        animator.ResetTrigger("damage");
        animator.SetTrigger("origin");
        animator.ResetTrigger("jump");
        if(angry_text.text == "THANK YOU!!")
        {
            yield return new WaitForSeconds(5f);
            angry_text.text = "LET'S GO !!";
        }

    }

}
