using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Show_Monitor : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Monitor_Panel;
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
            Monitor_Panel.SetActive(true);

        }

    }
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Enter " + collision.gameObject.name);
        if (collision.gameObject.name == "Root")
        {
            Monitor_Panel.SetActive(false);

        }

    }

}
