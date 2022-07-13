using System;

public interface IInventoryItem
{ 
    public bool IsEquipped { get; set; }
    public Type Type { get; }
    public int MaxItemsInInventorySlot { get; }
    public int Amout { get; set; }

    IInventoryItem Clone();
}