using System;

public interface IInventory
{
    public int Capacity { get; }
    public bool IsFull { get; }

    public IInventoryItem GetItem(Type itemType);
    public IInventoryItem[] GetAllItems();
    public IInventoryItem[] GetAllItems(Type itemType);
    public IInventoryItem[] GetEqieppedItems();
    public int GetItemAmout(Type itemType);

    public bool TryToAdd(object sender, IInventoryItem item);
    public bool TryToRemove(object sender, Type itemType, int amount = 1);
    public bool HasItem(Type type, IInventoryItem item);
}