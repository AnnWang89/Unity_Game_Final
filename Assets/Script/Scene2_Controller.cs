using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Scene2_Controller : MonoBehaviour
{
    // Start is called before the first frame update
    public Button musicBtn;
    public AudioClip bgm;
    AudioSource audiosource;
    public Text bgmText;
    int counter = 0;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Start Scene2!");
        audiosource = GetComponent<AudioSource>();
        audiosource.PlayOneShot(bgm);
        musicBtn.onClick.AddListener(musicONandOFF);

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void musicONandOFF()
    {
        if (counter % 2 == 0)
        {
            bgmText.text = "BGM OFF";
            audiosource.Pause();
        }
        else
        {
            bgmText.text = "BGM ON";
            audiosource.Play();
        }
        counter++;
        //Debug.Log("CLICK Back!");
        //SceneManager.LoadScene("MainUI");
        //Debug.Log("MainUI Load Success");
    }
    //private void ClickBack()
    //{
    //    Debug.Log("CLICK Back!");
    //    SceneManager.LoadScene("MainUI");
    //    Debug.Log("MainUI Load Success");
    //}
}
