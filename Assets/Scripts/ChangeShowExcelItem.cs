using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChangeShowExcelItem : MonoBehaviour
{
    [SerializeField] private ExcelIMasterData _excelMasterData;
    
    [SerializeField] private TextMeshProUGUI _itemNameText;
    [SerializeField] private TextMeshProUGUI _healVolumeText;
    [SerializeField] private TextMeshProUGUI _itemExplainText;
    [SerializeField] private Button _itemUseButton;

    public void ChangeExcelItem(int itemId)
    {
        switch (_excelMasterData.ExcelItemDatas[itemId].Kind)
        {
            case ItemKind.Food:
                _healVolumeText.text = _excelMasterData.ExcelItemDatas[itemId].HealPoint.ToString();
                break;
            case ItemKind.Object:
                _healVolumeText.text = "-";
                break;
        }
        
        _itemNameText.text = _excelMasterData.ExcelItemDatas[itemId].ItemName;
        _itemExplainText.text = _excelMasterData.ExcelItemDatas[itemId].ExplainText;
        _itemUseButton.interactable = _excelMasterData.ExcelItemDatas[itemId].CanUse;
    }
}
