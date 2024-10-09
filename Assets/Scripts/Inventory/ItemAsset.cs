using UnityEngine;

namespace InventorySystem
{
    public class ItemAsset : MonoBehaviour
    {
        public Sprite swordSprite;
        public Sprite healthPotionSprite;
        public Sprite goldSprite;

        public static ItemAsset instance;
        private void Awake()
        {
            instance = this;
        }
    }
}
