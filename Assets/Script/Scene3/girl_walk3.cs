
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class girl_walk3 : MonoBehaviour
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
    public GameObject Lights;

    public AudioSource switch_sound; // audio of the switcher
    public ParticleSystem dust_particles; // dust particles

    private Light spotlight;
    private Material ambient_light_material;
    private Color ambient_mat_color;
    private bool is_enabled = true;
    void Start()
    {
        animator = GetComponent<Animator>();
        charController = GetComponent<CharacterController>(); //§âCharacterController¸j¨ìcontroller
        spotlight = Lights.transform.Find("Spotlight").GetComponent<Light>();
        ambient_light_material = Lights.transform.Find("ambient").GetComponent<Renderer>().material;
        ambient_mat_color = ambient_light_material.GetColor("_TintColor");
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

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Switch();
            Debug.Log("Switch ");
            
        }
        rotationDircetion = new Vector3(0, Input.GetAxisRaw("Horizontal") * _rotationSpeed * Time.deltaTime, 0);
        moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        moveDirection = transform.TransformDirection(moveDirection*4);
        moveDirection *= moveSpeed;
        moveDirection.y -= gravity * Time.deltaTime;
        charController.Move(moveDirection * Time.deltaTime);
        transform.Rotate(rotationDircetion);
    }
    public void Switch()
    {
        Debug.Log("Switch in");
        
        is_enabled = !is_enabled;

        Lights.SetActive(is_enabled);

        if (switch_sound != null)
            switch_sound.Play();
       
    }

    public void Enable_Particles(bool value)
    {
        if (dust_particles != null)
        {
            if (value)
            {
                dust_particles.gameObject.SetActive(true);
                dust_particles.Play();
            }
            else
            {
                dust_particles.Stop();
                dust_particles.gameObject.SetActive(false);
            }
        }
    }
   
}

