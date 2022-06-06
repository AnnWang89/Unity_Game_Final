using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class girl_death : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //private void OnCollisionEnter(Collision other)
    //{
    //    if (other.gameObject.name == "w_sword_B")
    //    {
    //        Debug.Log("dead");
    //    }
    //}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "w_sword_B")
        {
            Debug.Log("dead");
        }
    }
}
