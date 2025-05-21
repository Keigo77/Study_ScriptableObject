using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MasterData", menuName = "Scriptable Objects/MasterData")]
public class MasterData : ScriptableObject
{
    public List<ItemData> ItemDatas = new();
}

// ItemData�̊e�l��Unity�Őݒ�ł���悤�ɂ���
[System.Serializable]
public class ItemData
{
    public string ItemName;
    public int Point;
    public Sprite Sprite;
    public string ExplainText;
}