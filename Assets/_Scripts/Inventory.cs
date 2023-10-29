using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] private bool[] _isFull;
    [SerializeField] private GameObject[] _slots;

    public bool[] IsFull => _isFull;
    public GameObject[] Slots => _slots;
}
