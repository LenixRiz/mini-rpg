using UnityEngine;

public class Inventory : MonoBehaviour
{
    public Item[] items;
    public int maxSlot = 10;

    private void Start()
    {
        items = new Item[maxSlot];
    }

    public void AddItem(CollectableItem collectable)
    {
       for (int i = 0; i < items.Length; i++)
       {
            if (items[i] == null)
            {
                //if there is a space, it will colect
                items[i] = collectable.CollectItem();
                return;
            }
        }
    }
}
