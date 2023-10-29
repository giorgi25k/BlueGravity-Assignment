using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : MonoBehaviour
{
    private Inventory _inventory;
    [SerializeField] private int _slotIndex;
    [SerializeField] private Transform _slot;

    private void Start()
    {
        _inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    public void DropItem()
    {
        foreach (Transform item in _slot)
        {
            if (_inventory.IsFull[_slotIndex])
            {
                item.GetComponent<ItemSpawn>().SpawnDroppedItem();
                Destroy(item.gameObject);
                _inventory.IsFull[_slotIndex] = false;
            }
        }
    }
}
