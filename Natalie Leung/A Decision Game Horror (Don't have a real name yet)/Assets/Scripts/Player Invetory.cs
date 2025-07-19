using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInvetory : MonoBehaviour
{
    private List<string> inventory = new List<string>();

    public void Add_Inventory(string item)
    {
        inventory.Add(item);
    }
}
    