using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class OutfitChanger : MonoBehaviour
{
    [SerializeField] OutfitObject _outfitObject;
    [SerializeField] SpriteRenderer[] _spriteToChange;
    [SerializeField] GameObject _buyButton;
    [SerializeField] GameObject _sellButton;
    [SerializeField] GameObject _chooseButton;

    [SerializeField] private Image _skinImage;
    [SerializeField] private TMP_Text _skinName;
    [SerializeField] private TMP_Text _priceText;
    
    private int _cost;
    private Sprite[] _skin;
    private bool _isBought;

    private void Start()
    {
        _skinName.text = _outfitObject.SkinName;
        _skin = _outfitObject.Skin;
        _skinImage.sprite = _outfitObject.SkinImage;
        _cost = _outfitObject.Cost;
        _priceText.text = _cost.ToString();
    }

    public void Buy()
    {
        if (PlayerController.Money < _cost) return;

        for (int i = 0; i < _spriteToChange.Length; i++)
        {
            _spriteToChange[i].sprite = _skin[i];
        }

        _isBought = true;
        _buyButton.SetActive(false);
        _chooseButton.SetActive(true);
        _sellButton.SetActive(true);
        PlayerController.Money -= _cost;
        UIController.Instance.UpdateMoneyCount(PlayerController.Money);
    }

    public void Choose()
    {
        for (int i = 0; i < _spriteToChange.Length; i++)
        {
            _spriteToChange[i].sprite = _skin[i];
        }
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