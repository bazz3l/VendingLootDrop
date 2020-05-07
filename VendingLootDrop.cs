namespace Oxide.Plugins
{
    [Info("Vending Loot Drop", "Bazz3l", "1.0.2")]
    [Description("Drops vending machine loot when destroyed.")]
    class VendingLootDrop : RustPlugin
    {
        #region Oxide
        void OnEntityDeath(VendingMachine machine)
        {
            if (machine == null || machine.inventory == null || machine.inventory.itemList == null)
            {
                return;
            }

            machine.dropChance = 0.75f;
        }
        #endregion
    }
}