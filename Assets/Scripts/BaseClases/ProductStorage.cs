using System.Collections.Generic;
using System.Data.SqlTypes;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu (fileName = "Product", menuName = "ScriptableObjects/BonusWindow/ProductStorage")]
public class ProductStorage : ScriptableObject
{
    public static ProductStorage Instance;
    
    public List<BigIconData> BigIcons;
    public List<ProductData> Products;
    
   public Texture2D GetBigIcons(string name) => BigIcons.Find(i => i.name == name).texture;
   public ProductData GetProduct(string name) => Products.Find(i => i.name == name);

    public static ProductStorage GetStorage()
    {
        
        if (!Instance)
        {
            Instance = Resources.Load("Storage") as ProductStorage;
        }
        
        return Instance;
    }
}