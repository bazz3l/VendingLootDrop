namespace Oxide.Plugins
{
    [Info("Vending Loot Drop", "Bazz3l", "1.0.2")]
    [Description("Drops vending machine loot when destroyed.")]
    class VendingLootDrop : RustPlugin
    {
        #region Oxide
        void OnEntitySpawned(VendingMachine machine)
        {
            if (machine != null)
            {
                machine.dropChance = 0.75f;
            }
        }
        #endregion
    }
}