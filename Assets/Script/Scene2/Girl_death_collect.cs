using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Girl_death_collect : MonoBehaviour
{
    public AudioClip deathMusic;
    public AudioClip collectMusic;
    public Image dressPic;
    public Image lipstickPic;
    public Image hairpinPic;
    public Image highheelPic;
    public Text startMsg;
    public Text successMsg;
    public Text lpMsg;

    private Vector3 girlOrigPos= new Vector3(57f, -1f, 470.7f);
    private int lp = 5;
    private int collectNum = 0;

    AudioSource audiosource;

    // Start is called before the first frame update
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
}

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "w_sword_B")
        {
            Debug.Log("lp--");
            lp--;
            lpMsg.text = "x" + lp;

            if(lp == 0)
            {
                audiosource.PlayOneShot(deathMusic);
                transform.position = girlOrigPos;
                SceneManager.LoadScene("MainUI");
                lp = 5;
            }
        }
        else if(other.gameObject.name == "Dress" || other.gameObject.name == "Lipstick" || other.gameObject.name == "Hairpin" || other.gameObject.name == "Shoes")
        {
            audiosource.PlayOneShot(collectMusic);
            audiosource.Play();
            Destroy(other.gameObject);
            collectNum++;

            if (other.gameObject.name == "Dress")
            {
                dressPic.enabled = true;
                Debug.Log("Dress");
            }
            else if (other.gameObject.name == "Lipstick")
            {
                lipstickPic.enabled = true;
                Debug.Log("Lipstick");
            }
            else if (other.gameObject.name == "Hairpin")
            {
                hairpinPic.enabled = true;
                Debug.Log("Hairpin");

            }
            else if (other.gameObject.name == "Shoes")
            {
                highheelPic.enabled = true;
                Debug.Log("Shoes");
            }
        }
        else if(other.gameObject.name == "castle_gate_b")
        {
            startMsg.enabled = false;
        }
        

        if (collectNum == 4)
        {
            successMsg.enabled = true;

            if(other.gameObject.name == "castle_gate_a")
            {
                SceneManager.LoadScene("Scene3");
            }
        }
    }
}
