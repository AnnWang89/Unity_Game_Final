using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene1_Ewall : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] cube = new GameObject[50];
    void Start()
    {
        for (int i = 0; i < 50; i++)
        {
            cube[i].transform.position = new Vector3(600, 10, (600-i*10));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
