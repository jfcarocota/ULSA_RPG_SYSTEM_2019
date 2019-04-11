using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Core.Movement.Sys3D;


public abstract class Player : NPC
{
    /*private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    new void Update()
    {
        base.Update();
    }*/

    [SerializeField]
    AudioSource aud;

    public abstract void Move();

    protected virtual void Attack()
    {
        DoSomething();
    }

    protected virtual void Attack2(int value1, float value2)
    {

    }

    protected void DoSomething()
    {

    }
}
