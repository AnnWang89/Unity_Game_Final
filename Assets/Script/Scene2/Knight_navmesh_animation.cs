using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Knight_navmesh_animation : MonoBehaviour
{
    private NavMeshAgent knight;
    private Vector3 originalPos;
    public Transform girl;
    private float chaseDist = 100f;
    private float attackDist = 20f;
    //private bool is

    public AudioClip runMusic;
    public AudioClip attackMusic;

    Animator animator;
    AudioSource audiosource;

    // Start is called before the first frame update
    void Start()
    {
        knight = GetComponent<NavMeshAgent>();
        originalPos = GetComponent<Transform>().position;
        animator = GetComponent<Animator>();
        audiosource = GetComponent<AudioSource>();
        //Debug.Log(originalPos+"orig");
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Vector3.Distance(transform.position, girl.position));

        if (Vector3.Distance(transform.position, girl.position) < chaseDist)
        {
            //StartCoroutine(playRunMusic());
            //playRunMusic();
            knight.SetDestination(girl.position);
            animator.SetBool("attack", false);
            animator.SetBool("wait", false);
            animator.SetBool("run", true);

            if (Vector3.Distance(transform.position, girl.position) < attackDist)
            {
                //playAttackMusic();
                animator.SetBool("run", false);
                animator.SetBool("attack", true);
            }
            //audiosource.Play();
        }
        else
        {
            if (Vector3.Distance(transform.position, originalPos) <= 2f)
            {
                animator.SetBool("run", false);
                animator.SetBool("wait", true);
                //Debug.Log("Stop");
            }
            else
            {
                knight.SetDestination(originalPos);
                //Debug.Log("back");
            }
        }
    }

    IEnumerator playRunMusic()
    {
        audiosource.PlayOneShot(runMusic);
        yield return new WaitForSeconds(0.5f);
    }
    public void playAttackMusic()
    {
        audiosource.PlayOneShot(attackMusic);
    }

    IEnumerator Example()
    {
        print(Time.time);
        yield return new WaitForSeconds(0.5f);
        print(Time.time);
    }
}
