using UnityEngine;

namespace InventorySystem
{
    public class ItemAsset : MonoBehaviour
    {
        public Sprite axeSprite;
        public Sprite woodSprite;
        public Sprite goldSprite;

        public static ItemAsset instance;
        private void Awake()
        {
            instance = this;
        }
    }
}
