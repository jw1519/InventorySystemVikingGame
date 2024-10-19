using InventorySystem;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Wood : Item, IStackable
{
    Transform parent
    {
        get
        {
            return gameObject.GetComponentInParent<Transform>();
        }
    }

    public void AddToStack(Item itemToAdd, int amountToAdd, int currentAmount, int maxValue)
    {

        if (currentAmount + amountToAdd <= maxValue)
        {
            parent.FindChild(itemToAdd.itemName);
        }
        
    }
}
