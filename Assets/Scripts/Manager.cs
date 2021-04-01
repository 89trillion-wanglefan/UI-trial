using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;
using System.IO;

/// <summary>
/// 主要控制类
/// </summary>
public class Manager : MonoBehaviour
{
    public GameObject Button;//开始按钮
    public SetFreeInfo Place1;//免费卡片位
    public SetInfo Place2;//卡片位
    public SetInfo Place3;
    public SetInfo Place4;
    public SetInfo Place5;
    public GameObject DailyShop;//商店UI

    private Card card;//卡片信息
    private JSONNode dataJson;//读取json用的变量

    private readonly List<Card> listCards = new List<Card>();//卡片信息列表

    /// <summary>
    /// 读取卡片数据，初始化商店界面
    /// </summary>
    void Start()
    {
        StreamReader streamReader = new StreamReader(Application.dataPath + "/StreamingAssets/data.json");
        string str = streamReader.ReadToEnd();
        dataJson = JSON.Parse(str);
        dataJson = dataJson["dailyProduct"];
        for (var i = 0; i < dataJson.Count; i++)
        {
            if (dataJson[i]["type"].AsInt == 3)
                card = new Card(dataJson[i]["type"].AsInt, dataJson[i]["costGold"].AsInt,
                    dataJson[i]["isPurchased"].AsInt, dataJson[i]["subType"].AsInt);
            else card = new Card(dataJson[i]["type"].AsInt, dataJson[i]["isPurchased"].AsInt);
            listCards.Add(card);
        }
        Place1.ShowInfo(listCards[0]);
        Place2.ShowInfo(listCards[1]);
        Place3.ShowInfo(listCards[2]);
        Place4.ShowInfo(listCards[3]);
        Place5.ShowInfo(listCards[4]);
    }
    
    /// <summary>
    /// 对应不同卡片位的按钮，注册给不同的卡片信息
    /// </summary>
    public void Click1()
    {
        listCards[0].Purchased = 1;
        Place1.ShowInfo(listCards[0]);
    }
    public void Click2()
    {
        listCards[1].Purchased = 1;
        Place2.ShowInfo(listCards[1]);
    }
    public void Click3()
    {
        listCards[2].Purchased = 1;
        Place3.ShowInfo(listCards[2]);
    }
    public void Click4()
    {
        listCards[3].Purchased = 1;
        Place4.ShowInfo(listCards[3]);
    }
    public void Click5()
    {
        listCards[4].Purchased = 1;
        Place5.ShowInfo(listCards[4]);
    }
    /// <summary>
    /// 设置去往商店界面的按钮
    /// </summary>
    public void ToDailyShop()
    {
        Button.SetActive(false);
        DailyShop.SetActive(true);
    }
}
