using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPickup : MonoBehaviour, IPickupable
{
    [SerializeField] private GameObject _itemButton;

    private Inventory _inventory;

    private void Start()
    {
        _inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    public void Pickup()
    {
        for (int i = 0; i < _inventory.Slots.Length; i++)
        {
            if (_inventory.IsFull[i] == false)
            {
                _inventory.IsFull[i] = true;
                Instantiate(_itemButton, _inventory.Slots[i].transform, false);
                Destroy(gameObject);
                break;
            }
        }
    }

}
