using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] private MasterData _masterData;
    private int _point;
    private SpriteRenderer _spriteRenderer;

    void Awake()
    {
        _spriteRenderer = this.GetComponent<SpriteRenderer>();
    }
    
    void Start()
    {
        int randItemID = Random.Range(0, 3);
        _point = _masterData.ItemDatas[randItemID].Point;
        _spriteRenderer.sprite = _masterData.ItemDatas[randItemID].Sprite;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag("Player")) { return; }
        
        ScoreManager.Score.Value += _point;
        Destroy(this.gameObject);
    }
}
