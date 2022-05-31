using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene1_Swall : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] cube = new GameObject[47];
    void Start()
    {
        for (int i = 0; i < 47; i++)
        {
            cube[i].transform.position = new Vector3((600- i*10), 10, 100);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
