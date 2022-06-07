using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scene1_Nwall : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] cube = new GameObject[47];
    void Start()
    {
        for(int i=0; i<47; i++)
        {
            cube[i].transform.position = new Vector3((100 + i*10), 10, 600);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
