using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TalkSystem : MonoBehaviour
{
    IEnumerator<WaitForSeconds> checkConv;

    [SerializeField]
    GameObject talkSystemUI;
    [SerializeField]
    Text textMessage;
    [SerializeField]
    string message = "";

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
        textMessage.text = message;
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
}

