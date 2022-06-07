using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
[RequireComponent(typeof(AudioSource))]
public class MainUI_Controller : MonoBehaviour
{
    // Start is called before the first frame update
    public Button btnStart1, btnStart2, btnStart3, btnStory, btnEnd;
    public GameObject Panel_Setting;
    public GameObject Panel_main;
    public GameObject Canvas_Setting;
    public AudioClip bgm;
    AudioSource audiosource;
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
        audiosource.PlayOneShot(bgm);
        btnStory.onClick.AddListener(ClickStory);
        btnStart1.onClick.AddListener(ClickStart1);
        btnStart2.onClick.AddListener(ClickStart2);
        btnStart3.onClick.AddListener(ClickStart3);
        btnEnd.onClick.AddListener(ClickEnd);
        DontDestroyOnLoad(Canvas_Setting);
    }

    // Update is called once per frame
    void Update()
    {
        //test test
    }

    private void ClickStory()
    {
        Panel_Setting.SetActive(true);
        Panel_main.gameObject.SetActive(false);
        Debug.Log("CLICK Setting!");
    }
    private void ClickStart1()
    {
        Debug.Log("CLICK Start!");
        SceneManager.LoadScene("Scene1");
        Debug.Log("Scene1 Load Success");
    }
    private void ClickStart2()
    {
        Debug.Log("CLICK Start!");
        SceneManager.LoadScene("Scene2");
        Debug.Log("Scene2 Load Success");
    }
    private void ClickStart3()
    {
        Debug.Log("CLICK Start!");
        SceneManager.LoadScene("Scene3");
        Debug.Log("Scene3 Load Success");
    }
    private void ClickEnd()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        
        Application.Quit();
        Debug.Log("Game Over");
        //Destroy(canvas);
    }


}
