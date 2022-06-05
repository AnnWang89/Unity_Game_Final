using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioSource))]

public class Scene1_Controller : MonoBehaviour
{
    public Button musiccontrol;
    public Button weathercontrol;
    public AudioClip bgm;
    AudioSource audiosource;
    public GameObject Guide;
    public Text Guidetext;
    public Text bgmtext;
    public GameObject door;
    public GameObject opendoor;
    public GameObject particlesystem;
    private Vector3 rotationDircetion;
    int counter = 0;
    int weathercounter;
    int trigger = 0;
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
        audiosource.PlayOneShot(bgm);
        musiccontrol.onClick.AddListener(musicONandOFF);
        weathercontrol.onClick.AddListener(snow);
        Guidetext.text = "Hello！Could you help me find the key of my house?"+"\n"+"Love U Princess ^ ^"+"\n"+ "                                                           < Press Space to start & forward to open door> ";
        Guide.gameObject.SetActive(true);
        Debug.Log("start!");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Guide.gameObject.SetActive(false);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "opendoor" && trigger ==0)
        {
            trigger = 1;
            Debug.Log("opennnnnn");
            rotationDircetion = new Vector3(0, 0, 90);
            door.gameObject.transform.Rotate(rotationDircetion);
        }

    }
    private void musicONandOFF()
    {
        if(counter%2==0)
        {
            bgmtext.text = "BGM OFF";
            audiosource.Pause();
        }
        else
        {
            bgmtext.text = "BGM ON";
            audiosource.Play();
        }
        counter++;
        //Debug.Log("CLICK Back!");
        //SceneManager.LoadScene("MainUI");
        //Debug.Log("MainUI Load Success");
    }
    private void snow()
    {
        if (weathercounter % 2 == 0)
        {
            particlesystem.GetComponent<ParticleSystem>().Stop();
        }
        else
        {
            particlesystem.GetComponent<ParticleSystem>().Play();
        }
        weathercounter++;

    }
}

