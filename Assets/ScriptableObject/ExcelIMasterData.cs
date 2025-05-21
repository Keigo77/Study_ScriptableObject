using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExcelAsset]
public class ExcelIMasterData : ScriptableObject	// クラス名は，Excelのファイル名と同じであること
{
	// public List<[マスターデータの変数などを定義したクラス名]> [Excelのシート名];
	public List<ExcelItemDataEntity> ExcelItemDatas; // Replace 'EntityType' to an actual type that is serializable.
}
