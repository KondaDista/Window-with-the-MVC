using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ViewBonusWindow : ViewWindow
{
    [SerializeField] private List<ViewProduct> productsBuy;
    [SerializeField] private RawImage bigIconBonus;
    [SerializeField] private TMP_Text titleText;
    [SerializeField] private TMP_Text descriptionText;
    [SerializeField] private TMP_Text newPriceText;
    [SerializeField] private TMP_Text oldPriceText;
    [SerializeField] private TMP_Text discountText;
    
    [SerializeField] private Button buttonBuy;

    public override void SetBuyButton(UnityAction unityEvent)
    {
        buttonBuy.onClick.AddListener(unityEvent);
    }

    public override void DisplayBonusObjects(List<Product> products)
    {
        for (int i = 0; i < products.Count; i++)
            productsBuy[i].Init(products[i].texture, products[i].count);
    }

    public override void DisplayBigIconBonus(Texture2D texture)
    {
        bigIconBonus.texture = texture;
    }

    public override void DisplayPriceText(float newPrice)
    {
        HidePriceDiscount();
        newPriceText.text = $"${newPrice.ToString()}";
    }

    public override void DisplayPriceTextWithDiscount(float newPrice, float oldPrice, float discount)
    {
        ShowPriceDiscount();
        newPriceText.text = $"${newPrice.ToString()}";
        oldPriceText.text = $"$ {oldPrice.ToString()}";
        discountText.text = $"-{discount.ToString()}%";
    }
    
    public override void DisplayBonusPanelText(string title, string description)
    {
        titleText.text = title;
        descriptionText.text = description;
    }

    private void HidePriceDiscount()
    {
        oldPriceText.gameObject.SetActive(false);
        discountText.transform.parent.gameObject.SetActive(false);
    }

    private void ShowPriceDiscount()
    {
        oldPriceText.gameObject.SetActive(true);
        discountText.transform.parent.gameObject.SetActive(true);
    }
    
    public override void ClearWindow()
    {
        foreach (var product in productsBuy)
            product.gameObject.SetActive(false);
        
        bigIconBonus.texture = null;
    }
}
