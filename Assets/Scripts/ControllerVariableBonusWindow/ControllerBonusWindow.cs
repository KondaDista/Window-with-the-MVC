using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerBonusWindow : ControllerWindow
{

    public ControllerBonusWindow(ModelWindow model, ViewWindow view) : base(model, view)
    {
        ShowWindow();
    }

    protected override void ShowWindow()
    {
        _viewWindow.SetBuyButton(() =>
        {
            _viewWindow.gameObject.SetActive(false);
            _viewWindow.ClearWindow();
            
        });
        _modelWindow.SetWindowTexts();
        _modelWindow.SetProductsImages();
        _modelWindow.SetBigIcon();
    }
}
