using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Core.Movement.Sys3D;

public class Player : NPC
{
   

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    new void Update()
    {
        base.Update();
    }
}
