using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class InventorySlot : IInventorySlot
{
    public bool IsFull => Amount==Capacity;

    public bool IsEmpty => Item == null;

    public IInventoryItem Item { get; private set; }

    public Type ItemType => Item.Type;

    public int Amount => IsEmpty? 0: Item.Amout;

    public int Capacity { get; private set; }

    public void SetItem(IInventoryItem item)
    {
        if(IsEmpty==false)
        {
            return;
        }

        this.Item = item;
        this.Capacity = item.MaxItemsInInventorySlot;
    }

    public void Clear()
    {
        if (IsEmpty == true)
        {
            return;
        }

        Item.Amout = 0;
        Item = null;
    }
}

