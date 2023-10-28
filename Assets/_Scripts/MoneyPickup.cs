using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyPickup : MonoBehaviour, IPickupable
{
    [SerializeField] private int _moneyAmount;

    public void Pickup()
    {
        PlayerController.Money += _moneyAmount;
        UIController.Instance.UpdateMoneyCount(PlayerController.Money);
        Destroy(gameObject);
    }

}
