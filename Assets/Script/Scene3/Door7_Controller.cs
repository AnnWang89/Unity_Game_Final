using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class Door7_Controller : MonoBehaviour
{
    // Start is called before the first frame update
    Animator animator;
    public TextMeshPro monitor_text;
    public AudioSource door_sound;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.O) && monitor_text.text =="OPEN")
        {
            animator.SetTrigger("open_door");
            Debug.Log("Open Door");
            animator.SetTrigger("opened");
            animator.ResetTrigger("close_door");
            door_sound.Play();
        }
        

        if (Input.GetKey(KeyCode.C))
        {
            animator.SetTrigger("close_door");
            Debug.Log("Close Door");
            animator.SetTrigger("closed");
            animator.ResetTrigger("open_door");
            door_sound.Play();
        }

    }
}
