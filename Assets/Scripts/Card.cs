/// <summary>
/// 卡片的属性类
/// </summary>
public class Card
{
    public int Cost { get; set; }
    public int Type { get; set; }
    public int Purchased { get; set; }
    public int SubType { get; set; }
    
    public Card(){}

    public Card(int type,int cost,int purchased,int subType)
    {
        Cost = cost;
        Type = type;
        SubType = subType;
        Purchased = purchased;
    }
    
    public Card(int type,int purchased)
    {
        Type = type;
        Purchased = purchased;
    }
    
}
