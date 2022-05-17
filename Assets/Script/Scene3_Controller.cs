using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Scene3_Controller : MonoBehaviour
{
    public Button btnBack;
    // Start is called before the first frame update
    void Start()
    {
        btnBack.onClick.AddListener(ClickBack);

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
