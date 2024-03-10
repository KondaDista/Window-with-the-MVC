using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class MainBonusWindow : MonoBehaviour
{
    [SerializeField] private ViewWindow _viewWindow;
    [SerializeField] private WindowData windowData;
    [SerializeField] private TMP_InputField inputField;
    [SerializeField] private Button buttonOpenPanel;
    [SerializeField] private int countProduct;

    private void Start()
    {
        buttonOpenPanel.onClick.AddListener((() =>
        {
            int.TryParse(inputField.text, out countProduct);
            OpenWindow();
        }));
    }

    public void OpenWindow()
    {
        ModelWindow modelWindow = new ModelBonusWindow(_viewWindow, windowData, countProduct);
        ControllerWindow controllerWindow = new ControllerBonusWindow(modelWindow, _viewWindow);
        _viewWindow.gameObject.SetActive(true);
    }

}
