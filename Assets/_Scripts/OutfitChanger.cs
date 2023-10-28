using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class OutfitChanger : MonoBehaviour
{
    [SerializeField] OutfitObject _outfitObject;
    [SerializeField] SpriteRenderer _spriteToChange;
    [SerializeField] GameObject _buyButton;
    [SerializeField] GameObject _sellButton;
    [SerializeField] GameObject _chooseButton;

    [SerializeField] private Image _skinImage;
    [SerializeField] private TMP_Text _skinName;
    [SerializeField] private int _cost;
    [SerializeField] private bool _isBought;

    private Sprite _skin;

    private void Start()
    {
        _skinName.text = _outfitObject.SkinName;
        _skin = _outfitObject.Skin;
        _skinImage.sprite = _outfitObject.Skin;
        _cost = _outfitObject.Cost;
    }

    public void Buy()
    {
        if (PlayerController.Money < _cost) return;

        _spriteToChange.sprite = _skin;
        _isBought = true;
        _buyButton.SetActive(false);
        _chooseButton.SetActive(true);
        _sellButton.SetActive(true);
        PlayerController.Money -= _cost;
        UIController.Instance.UpdateMoneyCount(PlayerController.Money);
    }

    public void Sell()
    {
        _isBought = false;
        _chooseButton.SetActive(false);
        _sellButton.SetActive(false);
        _buyButton.SetActive(true);
        PlayerController.Money += _cost;
        UIController.Instance.UpdateMoneyCount(PlayerController.Money);
    }
}