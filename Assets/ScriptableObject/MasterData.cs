using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MasterData", menuName = "Scriptable Objects/MasterData")]
public class MasterData : ScriptableObject
{
    public List<ItemData> ItemDatas = new();
}

// ItemData‚ÌŠe’l‚ğUnity‚Åİ’è‚Å‚«‚é‚æ‚¤‚É‚·‚é
[System.Serializable]
public class ItemData
{
    public string ItemName;
    public int Point;
    public Sprite Sprite;
    public string ExplainText;
}