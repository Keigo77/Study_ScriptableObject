using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemKind
{
    Food,
    Object
}

[System.Serializable] // �A�g���r���[�g��t�^(MonoBehaviour���p�������ɁCUnity��Œl��ύX�������Ƃ��Ɏg�p)
public class ExcelItemDataEntity
{
    // public�ŃG�N�Z���ŃC���|�[�g�������^�Ɩ��O���`
    public int ItemId; 
    public ItemKind Kind;
    public string ItemName;
    public int HealPoint;
    public bool CanUse;
    [TextArea]
    public string ExplainText;
}