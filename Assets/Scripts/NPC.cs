using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Core.Movement.Sys3D;

public class NPC : MonoBehaviour
{
    [SerializeField]
    protected bool isPartner;
    [SerializeField]
    private bool isLeader;

    [SerializeField, Range(0f, 10f)]
    protected float moveSpeed = 0f;

    protected Animator anim;

    [SerializeField]
    Transform follow;

    [SerializeField, Range(0f, 10f)]
    float maxDistanceFollow = 2f;

    public bool IsLeader { get => isLeader;
        set => isLeader = value; }

    public Transform Follow { get => follow;
        set => follow = value; }

    protected void Update()
    {
        if (isPartner)
        {
            if (isLeader)
            {
                LeaderBeahaviour();
            }
            else
            {
                PartnerBeahaviour();
            }
        }
        else
        {
            NPCBeahaviour();
        }
    }

    void PartnerBeahaviour()
    {
        bool followLeader = Vector3.Distance(transform.position, 
            follow.position) >= maxDistanceFollow;

        if (followLeader)
        {
            transform.LookAt(follow);
            transform.Translate(Vector3.forward *
                moveSpeed * Time.deltaTime);
            anim.SetFloat("move", 1);
        }
        else
        {
            anim.SetFloat("move", 0);
        }
    }

    void NPCBeahaviour()
    {
        
    }

    void LeaderBeahaviour()
    {
        Movement3D.MoveFacing(transform, moveSpeed);
        anim.SetFloat("move", Mathf.Abs(Movement3D.Axis.magnitude));
        Debug.Log(Mathf.Abs(Movement3D.Axis.magnitude));
    }
}
