using System;
using System.Collections.Generic;
using System.Threading;
using Cysharp.Threading.Tasks;
using UnityEngine;
using Random = UnityEngine.Random;

public class ItemGenerator : MonoBehaviour
{
    [SerializeField] private GameObject _itemPrefab;
    private CancellationToken _token;
    private Vector2 _generatePos;

    void Awake()
    {
        _token = this.GetCancellationTokenOnDestroy();
    }

    void Start()
    {
        GenerateItem().Forget();
    }

    private async UniTask GenerateItem()
    {
        while (true)
        {
            _generatePos = DecideRandPosition();
            var itemObj = Instantiate(_itemPrefab, _generatePos, Quaternion.identity);
            await UniTask.Delay(TimeSpan.FromSeconds(1.5f), cancellationToken: _token);
            await UniTask.Yield();
        }
    }

    private Vector2 DecideRandPosition()
    {
        Vector2 randPos;
        randPos.x = Random.Range(-7.0f, 7.0f);
        randPos.y = Random.Range(-3.0f, 2.0f);
        
        return randPos;
    }
}
