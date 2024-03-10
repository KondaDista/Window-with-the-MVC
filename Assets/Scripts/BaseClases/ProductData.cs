using UnityEngine;

[CreateAssetMenu (fileName = "Product", menuName = "ScriptableObjects/BonusWindow/Product")]
public class ProductData : ScriptableObject
{
    public Texture2D texture;
    public string name;
    public int count;
}
