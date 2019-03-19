using System;
using System.Collections.Generic;
using UnityEngine;

namespace Core.PartySystem
{
    [Serializable]
    public class PartySystem
    {
        /*[SerializeField]
        List<NPC> characters;*/

        //public List<NPC> Characters { get => characters; set => characters = value; }

        public void InitLeader()
        {
            //characters[0].IsLeader = true;
        }

        public void ChangeLeader()
        {
            /*NPC lastLeader = characters[0];
            lastLeader.IsLeader = false;
            characters.RemoveAt(0);
            //lastLeader.Follow = characters[0].transform;
            characters.Add(lastLeader);
            InitLeader();

            for(int i = 0; i < characters.Count; i++)
            {
                if( i > 0)
                {
                    characters[i].Follow = characters[i - 1].transform;
                }
            }*/
        }
    }
}
