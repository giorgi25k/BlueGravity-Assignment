using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickupUI : MonoBehaviour
{
    [SerializeField] private GameObject _itemPickupUI;
    private GameObject _enteredPlayer;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            _enteredPlayer = collision.gameObject;
            _itemPickupUI.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            _enteredPlayer = null;
            _itemPickupUI.SetActive(false);
        }
    }
}
