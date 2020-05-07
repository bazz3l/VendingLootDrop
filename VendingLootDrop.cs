using UnityEngine;

namespace Oxide.Plugins
{
    [Info("Vending Loot Drop", "Bazz3l", "1.0.2")]
    [Description("Drops vending machine loot when destroyed.")]
    class VendingLootDrop : RustPlugin
    {
        #region Fields
        const string _itemPrefab = "assets/prefabs/misc/item drop/item_drop.prefab";
        #endregion

        #region Oxide
        void OnEntityDeath(VendingMachine machine)
        {
            if (machine == null || machine.inventory == null || machine.inventory.itemList == null)
            {
                return;
            }

            if (machine.inventory.itemList.Count > 0)
            {
                machine.inventory.Drop(_itemPrefab, machine.ServerPosition + (Vector3.up * 0.3f), machine.ServerRotation);
            }
        }
        #endregion
    }
}