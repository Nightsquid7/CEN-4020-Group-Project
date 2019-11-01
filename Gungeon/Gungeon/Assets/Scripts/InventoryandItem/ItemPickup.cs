using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems; // for inventory

public class ItemPickup : MonoBehaviour
{

    public Item item;

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Picking Up" + item.name);
        bool wasPickedUp = Inventory.instance.Add(item);
        if (wasPickedUp)
        {
            Destroy(gameObject);
               
        }


    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // for Inventory
        if (EventSystem.current.IsPointerOverGameObject())
            return;
    }
}
