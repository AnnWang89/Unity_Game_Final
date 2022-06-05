using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class princess_words : MonoBehaviour
{

    public TextMeshPro princess_text;
    public GameObject bo_princess;
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
        if (collision.gameObject.name == "Root"&& princess_text.text == "NO!!")
        {
            princess_text.text = "I want my boomerang!!";

        }
        if (collision.gameObject.name == "Root" && princess_text.text == "YA!!")
        {
            princess_text.text = "THANK YOU!!";
            bo_princess.SetActive(true);
        }

    }
}
