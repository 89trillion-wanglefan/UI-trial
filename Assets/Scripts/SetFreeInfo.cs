using UnityEngine;
/// <summary>
/// 每日免费物品的显示设置
/// </summary>
public class SetFreeInfo : MonoBehaviour
{
    [SerializeField] private GameObject coin;
    [SerializeField] private GameObject diamond;
    [SerializeField] private GameObject button;
    [SerializeField] private GameObject bought;
    /// <summary>
    /// 显示免费物品
    /// </summary>
    /// 免费物品对应的卡片信息
    /// <param name="card"></param>
    public void ShowInfo(Card card)
    {
        if (card.Type == 1)
        {
            coin.SetActive(true);
        }
        if (card.Type == 2)
        {
            diamond.SetActive(true);
        }
        if (card.Purchased == 1)
        {
            button.SetActive(false);
            bought.SetActive(true);
        }
    }
}
