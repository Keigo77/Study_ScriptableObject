using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExcelAsset]
public class ExcelIMasterData : ScriptableObject	// �N���X���́CExcel�̃t�@�C�����Ɠ����ł��邱��
{
	// public List<[�}�X�^�[�f�[�^�̕ϐ��Ȃǂ��`�����N���X��]> [Excel�̃V�[�g��];
	public List<ExcelItemDataEntity> ExcelItemDatas; // Replace 'EntityType' to an actual type that is serializable.
}
