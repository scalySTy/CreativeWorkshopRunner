using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    [SerializeField] private GameObject[] _platformTemplates;
    [SerializeField] private Transform _player;

    private List<GameObject> _activeTiles = new List<GameObject>();
    private float _spawnPosition = 0.0f;
    private float _tileLength = 88.0f;
    private int _startTiles = 10;

    void Start()
    {
        for (int i = 0; i < _startTiles; i++)
        {
            SpawnPlatformTile();
        }
    }

    void Update()
    {
        if(_player.position.z - 100 > _spawnPosition - (_startTiles * _tileLength)) 
        {
            SpawnPlatformTile();
            DeletePlatformTile();
        }
    }

    private void SpawnPlatformTile()
    {
        GameObject tile = Instantiate(_platformTemplates[Random.Range(0, _platformTemplates.Length)], transform.forward * _spawnPosition, transform.rotation);
        _activeTiles.Add(tile);
        _spawnPosition += _tileLength;
    }

    private void DeletePlatformTile()
    {
        Destroy(_activeTiles[0]);
        _activeTiles.RemoveAt(0);
    }
}
