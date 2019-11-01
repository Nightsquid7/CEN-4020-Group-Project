//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class InventoriUI : MonoBehaviour
{
    public Transform itemsParent;
    public GameObject inventoryUI;

    Inventory inventory;
    InventoriSlot[] slots;

    // Start is called before the first frame update
    void Start()
    {
        inventory = Inventory.instance;
        inventory.onItemChangedCallBack += UpdateUI;

        slots = itemsParent.GetComponentsInChildren<InventoriSlot>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Inventory"))
        {
            inventoryUI.SetActive(!inventoryUI.activeSelf);


        }
    }

    void UpdateUI()
    {
        for (int i = 0; i < slots.Length; i++)
        {
            if (i < inventory.items.Count)
            {
                slots[i].AddItem(inventory.items[i]);
            }
            else 
            {
                slots[i].ClearSlot();
            }
        }
        Debug.Log("Updating ui");
    }
}
