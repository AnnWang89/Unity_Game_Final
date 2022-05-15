using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Setting_Controller : MonoBehaviour
{
    public Button btnBack;
    public GameObject MainUI_Panel;
    //public GameObject Canvas;
    // Start is called before the first frame update
    void Start()
    {
        btnBack.onClick.AddListener(ClickBack);
        //DontDestroyOnLoad(Canvas);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void ClickBack()
    {
        Debug.Log("CLICK Back!");
        MainUI_Panel.SetActive(true);
        this.gameObject.SetActive(false);
        
    }
}
