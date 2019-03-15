using System;
using System.Collections.Generic;
using UnityEngine;
using Core.PartySystem;

public class Gamemanager : MonoBehaviour
{
    [SerializeField]
    PartySystem partySystem;

    private void Start()
    {
        partySystem.InitLeader();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            partySystem.ChangeLeader();
        }
    }
}

