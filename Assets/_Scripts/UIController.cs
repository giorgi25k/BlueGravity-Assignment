using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public static UIController Instance;
    private void Awake()
    {
        Instance = this;
    }

    [SerializeField] private TMP_Text _moneyText;

    public void UpdateMoneyCount(int amount)
    {
        _moneyText.text = amount.ToString();
    }
}
