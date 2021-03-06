using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
[RequireComponent(typeof(AudioSource))]
public class Scene3_Controller : MonoBehaviour
{
    // Start is called before the first frame update
    public Button musiccontrol;
    public AudioClip bgm;
    AudioSource audiosource;
    public Text bgmtext;
    int counter = 0;
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
        audiosource.PlayOneShot(bgm);
        musiccontrol.onClick.AddListener(musicONandOFF);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void musicONandOFF()
    {
        if (counter % 2 == 0)
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
}
