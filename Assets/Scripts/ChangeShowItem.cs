using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChangeShowItem : MonoBehaviour
{
    [SerializeField] MasterData _masterData;

    [SerializeField] private Image _mainItemImage;
    [SerializeField] private TextMeshProUGUI _obtainableScoreText;
    [SerializeField] private TextMeshProUGUI _itemExplainText;

    void Start()
    {   
        ChangeItem(0);
    }
    
    public void ChangeItem(int itemId)
    {
        _mainItemImage.sprite = _masterData.ItemDatas[itemId].Sprite;
        _obtainableScoreText.text = _masterData.ItemDatas[itemId].Point.ToString();
        _itemExplainText.text = _masterData.ItemDatas[itemId].ExplainText;
    }
}
