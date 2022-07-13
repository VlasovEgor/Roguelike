using System;

public interface IInventorySlot
{
    public bool IsFull { get; }
    public bool IsEmpty { get; }
    public IInventoryItem Item { get; }
    public Type ItemType { get; }
    public int Amount { get; }
    public int Capacity { get;}

    public void SetItem(IInventoryItem item);
    public void Clear();
}