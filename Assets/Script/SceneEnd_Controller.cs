using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
[RequireComponent(typeof(AudioSource))]
public class SceneEnd_Controller : MonoBehaviour
{
    // Start is called before the first frame update
    public Button btnBack; 
    public AudioClip bgm;
    AudioSource audiosource;
    void Start()
    {
        btnBack.onClick.AddListener(ClickBack);
        audiosource = GetComponent<AudioSource>();
        audiosource.PlayOneShot(bgm);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void ClickBack()
    {
        Debug.Log("CLICK Back!");
        SceneManager.LoadScene("MainUI");
        Debug.Log("MainUI Load Success");
    }
}
