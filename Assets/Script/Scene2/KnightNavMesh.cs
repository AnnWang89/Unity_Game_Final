using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class KnightNavMesh : MonoBehaviour
{
    private NavMeshAgent knight;
    private Vector3 originalPos;
    public Transform girl;
    private float chaseDist = 100f;
    private float attackDist = 10f;

    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        knight = GetComponent<NavMeshAgent>();
        originalPos = GetComponent<Transform>().position;
        animator = GetComponent<Animator>();
        //Debug.Log(originalPos+"orig");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Vector3.Distance(transform.position, girl.position));

        if (Vector3.Distance(transform.position, girl.position) < chaseDist)
        {
            knight.SetDestination(girl.position);
            animator.SetBool("attack", false);
            animator.SetBool("wait", false);
            animator.SetBool("run", true);
            //Debug.Log(girl.position + " girl");
            //Debug.Log(transform.position + " tr");
            if (Vector3.Distance(transform.position, girl.position) < attackDist)
            {
                animator.SetBool("run", false);
                animator.SetBool("attack", true);
            }
        }
        else
        {
            if (Vector3.Distance(transform.position, originalPos) <= 2f)
            {
                animator.SetBool("run", false);
                animator.SetBool("wait", true);
                Debug.Log("Stop");
            }
            else
            {
                knight.SetDestination(originalPos);
                //Debug.Log("back");
            }
        }
        //knight.SetDestination(girl.position);
    }


    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.name == "Mesh_Costume_02_Skin" || other.gameObject.name == "Face_BlendShapes")
    //    {
    //        //Debug.Log("dead");
    //    }
    //}
}
