using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public abstract class ViewWindow : MonoBehaviour
{
    public abstract void ClearWindow();
    public abstract void SetBuyButton(UnityAction unityEvent);
    public abstract void DisplayBonusObjects(List<Product> products);
    public abstract void DisplayBigIconBonus(Texture2D texture);
    public abstract void DisplayPriceText(float newPrice);
    public abstract void DisplayPriceTextWithDiscount(float newPrice, float oldPrice, float discount);
    public abstract void DisplayBonusPanelText(string title, string description);
}
