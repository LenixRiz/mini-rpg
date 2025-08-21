using UnityEngine;

public class CollectableItem : MonoBehaviour
{
    public Item item;

    public Item CollectItem()
    {
        Destroy(gameObject);
        return item;
    }
}
