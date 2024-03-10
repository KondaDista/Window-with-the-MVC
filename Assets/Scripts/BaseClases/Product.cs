using UnityEngine;

public class Product
{
    public Texture2D texture;
    public int count;

    public Product(ProductData productData)
    {
        texture = productData.texture;
        count = productData.count;
    }
}
