using R3;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    // readOnly�����CScore.Value�Ƃ��Ă͑�����Ă������݂���
    public static readonly ReactiveProperty<int> Score = new ReactiveProperty<int>(0);
    [SerializeField] private TextMeshProUGUI _scoreText;

    void Awake()
    {
        Score.Subscribe(_ => ShowScoreUpdate());
    }

    private void ShowScoreUpdate()
    {
        _scoreText.text = $"Score: {Score.Value}";
    }
}
