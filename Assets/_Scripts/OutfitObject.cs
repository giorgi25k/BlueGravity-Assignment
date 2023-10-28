using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Outfit", menuName = "Outfits")]
public class OutfitObject : ScriptableObject
{
    public string SkinName;
    public Sprite Skin;
    public bool Owned;
}
