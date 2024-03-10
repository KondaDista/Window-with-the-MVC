using System.Collections.Generic;
using UnityEngine;

public class ModelBonusWindow : ModelWindow
{
    private int councountProducts;
    public ModelBonusWindow(ViewWindow view, WindowData windowData , int countProduct) : base(view, windowData)
    {
        councountProducts = countProduct;
    }
    
    public override void SetWindowTexts()
    {
        _viewWindow.DisplayBonusPanelText(titleText, descriptionText);
        if (discount > 0)
            _viewWindow.DisplayPriceTextWithDiscount(price - (price / 100) * discount , price, discount);
        else
            _viewWindow.DisplayPriceText(price);
    }
    
    public override void SetProductsImages()
    {
        List<Product> products = new();
        for (int i = 0; i < councountProducts; i++)
        {
            products.Add( new Product(ProductStorage.GetStorage().GetProduct(productsNames[i])));
        }
        _viewWindow.DisplayBonusObjects(products);
    }

    public override void SetBigIcon()
    {
       _viewWindow.DisplayBigIconBonus(ProductStorage.GetStorage().GetBigIcons(bigIcon));
    }
}
