using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;
public class Inventoryhandlerchocomint : MonoBehaviour
{
    private GameObject invMenu;
    List<ietm> inventory = new List<ietm>();
    void Start()
    {
        invMenu = transform.Find("InventoryMenu").gameObject;
        invMenu.SetActive(false);
    }
    void DrawItems(){
        foreach (ietm item in inventory){
            GameObject itemIcon = new GameObject();
            itemIcon.AddComponent<Image>();
            itemIcon.transform.SetParent(invMenu.transform, false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            invMenu.SetActive(!invMenu.activeSelf);
        }
    }

}

