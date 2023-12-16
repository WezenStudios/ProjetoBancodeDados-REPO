using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo : MonoBehaviour
{
    public InventoryManager inventoryManager;
    public Item[] itemsToPickup;

    public void PickupItem(int id)
    {
        bool result = inventoryManager.AddItem(itemsToPickup[id]);

        if(result == true)
        {
            Debug.Log("ITEM ADDED!");
        }
        else
        {
            Debug.Log("ITEM NOT ADDED...");
        }
    }
}
