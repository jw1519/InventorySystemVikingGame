using InventorySystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IStackable
{
    //items can be stacked
    Transform parent { get; }
    public void AddToStack(Item itemToAdd, int amountToAdd, int currentAmount, int maxValue);

}
