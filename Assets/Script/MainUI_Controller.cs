using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MainUI_Controller : MonoBehaviour
{
    // Start is called before the first frame update
    public Button btnStart, btnSetting, btnEnd;
    public GameObject Panel_Setting;
    public GameObject Canvas_Setting;
    void Start()
    {
        btnSetting.onClick.AddListener(ClickSetting);
        btnStart.onClick.AddListener(ClickStart);
        btnStart.onClick.AddListener(ClickEnd);
        DontDestroyOnLoad(Canvas_Setting);
    }

    // Update is called once per frame
    void Update()
    {
        //git test
    }

    private void ClickSetting()
    {
        Panel_Setting.SetActive(true); 
        this.gameObject.SetActive(false);
        Debug.Log("CLICK Setting!");
    }
    private void ClickStart()
    {
        Debug.Log("CLICK Start!");
        SceneManager.LoadScene("Scene1");
        Debug.Log("Scene1 Load Success");
    }
    private void ClickEnd()
    {
        //UnityEditor.EditorApplication.isPlaying = false;
        
        Application.Quit();
        Debug.Log("Game Over");
        //Destroy(canvas);
    }


}
