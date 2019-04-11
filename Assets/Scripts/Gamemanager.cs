using System;
using System.Collections.Generic;
using UnityEngine;
using Core.PartySystem;
//using Core.TalkSystem;

public class Gamemanager : MonoBehaviour
{
    public static Gamemanager instance;

    [SerializeField]
    PartySystem partySystem;
   // [SerializeField]
    TalkSystem talkSystem;
    

    private void Awake()
    {
        instance = this;
        talkSystem = GetComponent<TalkSystem>();
    }

    private void Start()
    {
        //talkSystem.InitConversation();
        //partySystem.InitLeader();
        //StartCoroutine(talkSystem.CheckConversation());
        //checkConv = CheckConversation();
        //StartCoroutine(checkConv);

    }

    public void InitConversation()
    {
        talkSystem.InitConversation();
    }

    private void Update()
    {
       if (Input.GetButtonDown("Submit"))
        {
            /* Debug.Log("Corutinas detenidas");
             StopAllCoroutines();*/
            //talkSystem.InitConversation();

        }
            /*if (Input.GetButtonDown("Jump"))
            {
                partySystem.ChangeLeader();
            }*/
        }
}

