using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace InventorySystem
{
    public class InventoryItem : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
    {
        public enum Item //declare the items
        {
            Sword,
            HealthPotion,
            Gold,
            QuestItem,
        }
        public Item itemType;
        public int Amount;
        public GameObject HoverInformation;
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

        public void OnPointerEnter(PointerEventData eventData) //when mouse hover over
        {

            HoverInformation.SetActive(true);
            ItemInformationTextMesh.SetText(itemInformation);
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            HoverInformation.SetActive(false);
        }
    }
}