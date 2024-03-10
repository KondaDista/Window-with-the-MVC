using System.Collections.Generic;
using UnityEngine;

public abstract class ModelWindow
{
    protected ViewWindow _viewWindow;

    protected string titleText;
    protected string descriptionText;
    protected float price;
    protected float discount;
    protected string bigIcon;
    protected List<string> productsNames = new();

    protected ModelWindow(ViewWindow view, WindowData windowData)
    {
        _viewWindow = view;
        titleText = windowData.titleText;
        descriptionText = windowData.descriptionText;
        price = windowData.price;
        discount = windowData.discount;
        bigIcon = windowData.bigIconBonus;
        productsNames = windowData.productsNames;
    }

    public abstract void SetWindowTexts();
    public abstract void SetProductsImages();
    public abstract void SetBigIcon();
}
