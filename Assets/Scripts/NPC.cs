using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Core.Movement.Sys3D;

public class NPC : MonoBehaviour
{
    [SerializeField]
    protected bool isPartner;
    [SerializeField]
    protected bool isLeader;

    [SerializeField, Range(0f, 10f)]
    protected float moveSpeed = 0f;

    protected Animator anim;

    [SerializeField]
    Transform follow;

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
        transform.LookAt(follow);
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
