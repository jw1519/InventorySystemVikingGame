using TMPro;
using UnityEngine;

namespace InventorySystem
{
    public class InventoryItem : MonoBehaviour
    {
        bool isClicked = false;
        public enum Item //declare the items
        {
            AxeHeads,
            Wood,
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
                case Item.AxeHeads: return ItemAsset.instance.axeSprite;
                case Item.Wood: return ItemAsset.instance.woodSprite;
                case Item.Gold: return ItemAsset.instance.goldSprite;
            }
        }
        public void OnClick()
        {
            if (isClicked == false)
            {
                ItemInformation.SetActive(true);
                ItemInformationTextMesh = ItemInformation.GetComponentInChildren<TextMeshProUGUI>();
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