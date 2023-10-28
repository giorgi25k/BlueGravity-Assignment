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
    [SerializeField] GameObject _chooseButton;

    [SerializeField] private Image _skinImage;
    [SerializeField] private TMP_Text _skinName;
    [SerializeField] private bool _isBought;

    private Sprite _skin;

    private void Start()
    {
        _skinName.text = _outfitObject.SkinName;
        _skin = _outfitObject.Skin;
        _skinImage.sprite = _outfitObject.Skin;
    }

    public void Buy()
    {
        _spriteToChange.sprite = _skin;
        _isBought = true;
        _buyButton.SetActive(false);
        _chooseButton.SetActive(true);
    }

    public void Sell()
    {
        _isBought = false;
        _chooseButton.SetActive(false);
        _buyButton.SetActive(true);
    }
}
