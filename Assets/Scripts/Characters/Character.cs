using System;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField]
    protected string characterName;
    [TextArea(5, 50), SerializeField]
    protected string lore;
}

