using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class Show_Computer : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Computer_text;
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
            Computer_text.SetActive(true);

        }

    }
    

}
