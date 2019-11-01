
using UnityEngine;
using UnityEngine.UI;
public class InventoriSlot : MonoBehaviour
{
    // Start is called before the first frame update
    public Image icon;
    Item item;
    public void AddItem (Item newItem)
    {
        item = newItem;
        icon.sprite = item.icon;
        icon.enabled = true;
    }
    public void ClearSlot()
    {
        item = null;
        icon.sprite = null;
        icon.enabled = false;
    }
}
