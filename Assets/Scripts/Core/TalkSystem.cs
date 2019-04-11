using System;
using System.Collections.Generic;
using UnityEngine;

public class TalkSystem : MonoBehaviour
{
    IEnumerator<WaitForSeconds> checkConv;

    [SerializeField]
    GameObject talkSystemUI;

    private void Start()
    {
        checkConv = CheckConversation();
        //StartCoroutine(checkConv);
        //InitConversation();
    }

    public void InitConversation()
    {
        StartCoroutine(checkConv);
    }

    public IEnumerator<WaitForSeconds> CheckConversation()
    {
        talkSystemUI.SetActive(true);
        while (true)
        {
            yield return new WaitForSeconds(3f);
            Debug.Log("Ya pasaron 3 segundos");
            /*if (!talkSystemUI.activeSelf)
            {
                talkSystemUI.SetActive(true);
            }*/
        }
    }

/*#if UNITY_STANDALONE_WIN
    public bool NextLine 
    { 
        get => Input.GetButtonDown("Submit"); 
    }
#elif UNITY_XBOXONE
    public bool NextLine 
    { 
        get => Input.GetButtonDown("SubmitXbox"); 
    }
#endif*/
}

