using System;
using System.Collections.Generic;
using UnityEngine;
using Core.Movement.ControlUtils;


public class Mage : Player
{
    public override void Move()
    {
        throw new NotImplementedException();
    }

    protected override void Attack()
    {
        //base.Attack();
    }

    protected override void Attack2(int value1, float value2)
    {
        base.Attack2(value1, value2);
    }

    private void Start()
    {
        DoSomething();
        Attack2(1, 0.1f);
        Attack();
    }

    private void OnTriggerStay(Collider other)
    {
        if (ControlUtils.Button_A)
        {
            Gamemanager.instance.InitConversation();
        }
    }
}

