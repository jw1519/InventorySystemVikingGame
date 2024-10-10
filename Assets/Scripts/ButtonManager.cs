using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    [Header("Inventory System")]
    public GameObject Inventorybutton;
    public GameObject Inventory;
    private bool isInventoryOpen = false;

    public void OpenAndCloseInventory()
    {
        if (isInventoryOpen == false)
        {
            isInventoryOpen = true;
            Inventory.SetActive(true);
        }
        else
        {
            isInventoryOpen= false;
            Inventory.SetActive(false);
        }
    }
}
