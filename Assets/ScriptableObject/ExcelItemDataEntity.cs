using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemKind
{
    Food,
    Object
}

[System.Serializable] // アトリビュートを付与(MonoBehaviourを継承せずに，Unity上で値を変更したいときに使用)
public class ExcelItemDataEntity
{
    // publicでエクセルでインポートしたい型と名前を定義
    public int ItemId; 
    public ItemKind Kind;
    public string ItemName;
    public int HealPoint;
    public bool CanUse;
    [TextArea]
    public string ExplainText;
}