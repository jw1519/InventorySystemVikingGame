using InventorySystem;
using UnityEngine;

public class InventorySetUp : MonoBehaviour
{
    [SerializeField] UI_Inventory uiInventory;
   public void Start()
    {
        Inventory inventory = new();
        uiInventory.SetInventory(inventory);
    }
}
