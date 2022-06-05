using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioSource))]

public class Scene1_Controller : MonoBehaviour
{
    //public Button btnBack;
    public AudioClip bgm;
    AudioSource audiosource;
    public GameObject Guide;
    public Text Guidetext;
    public GameObject door;
    private Vector3 rotationDircetion;
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
        audiosource.PlayOneShot(bgm);
        //btnBack.onClick.AddListener(ClickBack);
        Guidetext.text = "Hello！Could you help me find the key of my house?"+"\n"+"Love U Princess ^ ^"+"\n"+ "                                                                                            < Press Space to start > ";
        Guide.gameObject.SetActive(true);
        Debug.Log("start!");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            Debug.Log("space");
            Guide.gameObject.SetActive(false);
            rotationDircetion = new Vector3(0, 0, 90);
            door.gameObject.transform.Rotate(rotationDircetion);
            Debug.Log("open");
        } 
    }
    private void ClickBack()
    { 
        Debug.Log("CLICK Back!");
        SceneManager.LoadScene("MainUI");
        Debug.Log("MainUI Load Success");
    }
}
