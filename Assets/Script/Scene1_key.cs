using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scene1_key : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject key;
    public GameObject door;
    public GameObject Guide;
    public Text Guidetext;
    private Vector3 rotationDircetion;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log(other.transform.name);
        if (other.gameObject.name == "girl")
        {
            Destroy(this.gameObject);
            Guidetext.text = "Exit is opened!"+"\n"+ "                                                                                         < Press Space to start > ";
            Guide.gameObject.SetActive(true);
            if (Input.GetKey(KeyCode.Space))
            {
                Guide.gameObject.SetActive(false);
            }
            rotationDircetion = new Vector3(0, 0, 90);
            door.gameObject.transform.Rotate(rotationDircetion);
            Debug.Log("success");
        }
    }
}

