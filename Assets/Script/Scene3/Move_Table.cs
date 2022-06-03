using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class Move_Table : MonoBehaviour
{
    public TextMeshPro monitor_text;
    public GameObject hint_text;
    // Start is called before the first frame update
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
        if (collision.gameObject.name == "Table"|| collision.gameObject.name == "Table_1"|| collision.gameObject.name == "Table_2")
        {
            monitor_text.text = "OPEN";
            hint_text.SetActive(true);
        }

    }
}
