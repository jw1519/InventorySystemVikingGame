using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    [Header("Inventory System")]
    public GameObject Inventorybutton; // change image of inventory button if open or close
    public GameObject Inventory;
    [SerializeField] bool isInventoryOpen = false;

    public void OpenAndCloseInventory()
    {
        if (!isInventoryOpen)
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

    [Header("Menu")]
    public GameObject Menu;
    [SerializeField] bool isMenuOpen = false;

    public void OpenAndCloseMenu()
    {
        if (!isMenuOpen)
        {
            isMenuOpen= true;
            Menu.SetActive(true);
        }
        else
        {
            isMenuOpen = false;
            Menu.SetActive(false);
        }
    }

    [Header("Settings")]
    public GameObject Settings;
    [SerializeField] bool isSettingsOpen = false;
    public void OpenAndCloseSettings()
    {
        if (!isSettingsOpen)
        {
            isSettingsOpen = true;
            Settings.SetActive(true);
            Menu.SetActive(false);
        }
        else
        {
            isSettingsOpen = false;
            Settings.SetActive(false);
            Menu.SetActive(true);
        }
    }

    public void SaveGame()
    {
        Debug.Log("Game has been saved");
    }

    public void QuitGame()
    {
        
    }
}
