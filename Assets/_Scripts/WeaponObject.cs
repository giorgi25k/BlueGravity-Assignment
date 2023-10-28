using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Weapon", menuName = "Weapons")]
public class WeaponObject : ScriptableObject
{
    public string WeaponName;
    public Sprite WeaponImage;
    public Sprite[] WeaponSkin;
    public bool Owned;
    public int Cost;
}
