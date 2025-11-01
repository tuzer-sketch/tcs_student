
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEditor.SceneManagement;
public class Inventoryhandlerchocomint : MonoBehaviour
{
    private GameObject invMenu;
    [SerializeField] private List<ietm> inventory = new List<ietm>();
    void Start()
    {
        invMenu = transform.Find("InventoryMenu").gameObject;
        invMenu.SetActive(false);
    }
    public void additem(ietm item)
    {
        inventory.Add(item);
    }
    void DrawItems(){

        int x = 0;
        int col = 0;
        foreach (ietm item in inventory){
            GameObject itemIcon = new GameObject();
            itemIcon.AddComponent<Image>();
            itemIcon.GetComponent<Image>().sprite=item.icon;
            itemIcon.transform.SetParent(invMenu.transform, false);
            x += 1;
            RectTransform item_pos = itemIcon.GetComponent<RectTransform>();
            item_pos.anchoredPosition = new Vector2((x * 120) - 190, 3 * col);
            if (x>4)
            {
                x = 0;
                col += 1;
            }
        } 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            invMenu.SetActive(!invMenu.activeSelf);
            DrawItems();
        }
    }

}

