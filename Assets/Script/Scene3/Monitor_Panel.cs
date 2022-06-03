using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class Monitor_Panel : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI Input_num;
    public TextMeshPro monitor_text;
    public Button btn_1,btn_2, btn_3,btn_4,btn_5,btn_6,btn_7,btn_8,btn_9,btn_enter;
    string text_number;
    bool start_input = false;
    void Start()
    {
        btn_1.onClick.AddListener(Click1);
        btn_2.onClick.AddListener(Click2);
        btn_3.onClick.AddListener(Click3);
        btn_4.onClick.AddListener(Click4);
        btn_5.onClick.AddListener(Click5);
        btn_6.onClick.AddListener(Click6);
        btn_7.onClick.AddListener(Click7);
        btn_8.onClick.AddListener(Click8);
        btn_9.onClick.AddListener(Click9);
        btn_enter.onClick.AddListener(ClickEnter);

        Input_num.text = "LOCKED";
        text_number = "";
    }

    // Update is called once per frame
    void Update()
    {
        if(start_input)
        {
            Input_num.text = text_number;
        }
        
    }
    private void Click1()
    {
        start_input = true;
        Debug.Log("CLICK 1!");
        text_number = text_number+"1";
        
    }
    private void Click2()
    {
        start_input = true;
        Debug.Log("CLICK 2!");
        text_number = text_number + "2";

    }
    private void Click3()
    {
        start_input = true;
        Debug.Log("CLICK 3!");
        text_number = text_number + "3";
    }
    private void Click4()
    {
        start_input = true;
        Debug.Log("CLICK 4!");
        text_number = text_number + "4";

    }
    private void Click5()
    {
        start_input = true;
        Debug.Log("CLICK 5!");
        text_number = text_number + "5";

    }
    private void Click6()
    {
        start_input = true;
        Debug.Log("CLICK 6!");
        text_number = text_number + "6";

    }
    private void Click7()
    {
        start_input = true;
        Debug.Log("CLICK 7!");
        text_number = text_number + "7";


    }
    private void Click8()
    {
        start_input = true;
        Debug.Log("CLICK 8!");
        text_number = text_number + "8";

    }
    private void Click9()
    {
        start_input = true;
        Debug.Log("CLICK 9!");
        text_number = text_number + "9";

    }
    private void ClickEnter()
    {
        if(text_number == "159623")
        {
            start_input = false;
            text_number = "";
            Input_num.text = "OPEN";
            monitor_text.text = "OPEN";
            //this.gameObject.SetActive(false);
        }
        else
        {
            start_input = false;
            text_number = "";
            Input_num.text = "LOCLED";
        }
        Debug.Log("CLICK Enter!");


    }
   
}
