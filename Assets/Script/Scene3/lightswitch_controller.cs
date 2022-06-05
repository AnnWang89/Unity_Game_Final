using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightswitch_controller : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject lightswitch;
    public GameObject Lights;
    public AudioSource switch_sound; // audio of the switcher


    private Vector3 rotationDircetion;
    bool on = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        switch_sound.Play();
        //Debug.Log("Enter " + collision.gameObject.name);
        if (collision.gameObject.name == "Root")
        {
            
            if(!on)
            {
               
                rotationDircetion = new Vector3(50, 0, 0);
                lightswitch.transform.Rotate(rotationDircetion);
                Debug.Log("Enter on" + collision.gameObject.name);
                Lights.SetActive(true);
            }
            else
            {
                rotationDircetion = new Vector3(-50, 0, 0);
                lightswitch.transform.Rotate(rotationDircetion);
                Debug.Log("Enter off" + collision.gameObject.name);
                Lights.SetActive(false);
            }
            
        }

    }
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Enter " + collision.gameObject.name);
        if (collision.gameObject.name == "Root")
        {
            
            if (!on)
            {
                on = true;
            }
            else
            {
               on = false;
            }

        }



    }
}
