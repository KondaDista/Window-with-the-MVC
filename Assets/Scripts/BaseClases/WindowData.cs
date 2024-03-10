
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "WindowData", menuName = "ScriptableObjects/BonusWindow/WindowData")]
public class WindowData : ScriptableObject
{
    public string titleText;
    public string descriptionText;
    public float price;
    public float discount;
    public string bigIconBonus;
    public List<string> productsNames = new();
}