using UnityEngine;
using System.Collections.Generic;
public class Inventroysestem : MonoBehaviour
{
    List<ietm> items = new List<ietm>();
    [SerializeField] GameObject inventoryUI;
    void Start()
    {
        inventoryUI = transform.Find("InventoryUI").gameObject;
        inventoryUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
