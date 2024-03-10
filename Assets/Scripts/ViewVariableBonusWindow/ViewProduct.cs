using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ViewProduct : MonoBehaviour
{
    public RawImage imageProduct;
    public TMP_Text countText;

    public void Init(Texture2D texture, int count)
    {
        gameObject.SetActive(true);
        imageProduct.texture = texture;
        countText.text = count.ToString();
    }
}
