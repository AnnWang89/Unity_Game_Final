using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class Show_TV : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject TV_text;
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
            TV_text.SetActive(true);

        }

    }
    

}
