using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 收费物品的显示设置
/// </summary>
public class SetInfo : MonoBehaviour
{
    [SerializeField] private Text price;
    [SerializeField] private Image cardImage;
    [SerializeField] private GameObject button;
    [SerializeField] private GameObject bought;

    /// <summary>
    /// 显示收费物品信息
    /// </summary>
    /// 收费物品对应的卡片信息
    /// <param name="card"></param>
    public void ShowInfo(Card card)
    {
        price.text = card.Cost.ToString();
        cardImage.sprite = Resources.Load($"Images/{card.SubType}", typeof(Sprite)) as Sprite;
        if (card.Purchased == 1)
        {
            button.SetActive(false);
            bought.SetActive(true);
        }
    }
}