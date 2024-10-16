using UnityEngine;
using UnityEngine.UI;

namespace InventorySystem
{
    public class UI_Inventory : MonoBehaviour
    {
        private Inventory inventory;
        private Transform itemSlotContainer;
        private Transform itemSlotTemplate;

        public void SetInventory(Inventory inventory)
        {
            this.inventory = inventory;
            RefreshInvetoryItems();
        }
        private void Awake()
        {
            itemSlotContainer = transform.Find("ItemContainer");
            itemSlotTemplate = itemSlotContainer.Find("ItemSlot");
        }
        private void RefreshInvetoryItems() // this can be called when a new item is collected
        {
            int x = 0;
            int y = 0;
            float itemSlotCellSize = 30f;
            foreach (InventoryItem item in inventory.GetItemList())
            {
                RectTransform itemSlotRectTransform = Instantiate(itemSlotTemplate, itemSlotContainer).GetComponent<RectTransform>();
                itemSlotRectTransform.gameObject.SetActive(true);

                //locate the item in the grid
                itemSlotRectTransform.anchoredPosition = new Vector2(x * itemSlotCellSize, y * itemSlotCellSize);
                Transform Transform = itemSlotRectTransform.Find("ItemImage"); //name of component must be image
                if (Transform != null)
                {
                    Image image = Transform.GetComponent<Image>();
                    image.sprite = item.GetSprite();
                }
                x++;
                if (x > 4)
                {
                    x = 0;
                    y++;
                }
            }
        }
    }
}