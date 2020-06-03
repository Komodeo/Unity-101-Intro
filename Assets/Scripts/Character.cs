using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //declare
        string characterName;

        //assign
        characterName = "Grant"

        int characterLevel = 10;
        int experience = characterLevel * 5;

        float itemDurability = 1.567f;

        experience = (int)itemDurability;

        characterName = itemDurability.ToString();

        

        bool equippable = false;
        if (itemDurability > 1f)
        {
            experience = (int)(itemDurability * 1.5f) / characterLevel;
        }

    }

}
