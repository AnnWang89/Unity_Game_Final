using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class getup_music : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource music;

    public TextMeshPro angry_text;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {

        Debug.Log("Enter " + collision.gameObject.name);
        if (collision.gameObject.name == "Root")
        {
            angry_text.text = "NO!!";

            music.Play();

        }

    }
}
