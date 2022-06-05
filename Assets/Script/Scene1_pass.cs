using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Scene1_pass : MonoBehaviour
{
    public GameObject Guide;
    public Text Guidetext;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log(other.transform.name);
        if (other.gameObject.name == "girl")
        {
            Guidetext.text = "Thank you to find my key!!!!  And now, you can come in my house!" + "\n" + "Love you sooooo much <3";
            Guide.gameObject.SetActive(true);
            if (Input.GetKey(KeyCode.Space))
            {
               
            }
            StartCoroutine(Wait());
            //rotationDircetion = new Vector3(0, 0, 90);
            //door.gameObject.transform.Rotate(rotationDircetion);
        }
    }
    IEnumerator Wait()
    {
        Debug.Log("Waiting");

        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Scene2");
        Guide.gameObject.SetActive(false);
        



    }
}
