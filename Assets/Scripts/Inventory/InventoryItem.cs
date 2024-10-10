using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace InventorySystem
{
    public class InventoryItem : MonoBehaviour
    {
        bool isClicked = false;
        public enum Item //declare the items
        {
            Sword,
            HealthPotion,
            Gold,
            QuestItem,
        }
        public Item itemType;
        public int Amount;
        public GameObject ItemInformation;
        public TextMeshProUGUI ItemInformationTextMesh;

        public string itemInformation;

        public Sprite GetSprite()
        {
            switch (itemType)
            {
                default:
                case Item.Sword: return ItemAsset.instance.swordSprite;
                case Item.HealthPotion: return ItemAsset.instance.healthPotionSprite;
                case Item.Gold: return ItemAsset.instance.goldSprite;
            }
        }
        public void OnClick()
        {
            if (isClicked == false)
            {
                ItemInformation.SetActive(true);
                ItemInformationTextMesh.SetText(itemInformation);
                isClicked = true;
            }
            else
            {
                ItemInformation.SetActive(false);
                isClicked = false;
            }
        }
    }
}