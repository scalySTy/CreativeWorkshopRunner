using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    [SerializeField] private GameObject _platformTemplate;
    [SerializeField] private Transform _player;

    private float _spawnPosition = 0.0f;
    private float _tileLength = 100.0f;
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
        if(_player.position.z > _spawnPosition - (_startTiles * _tileLength)) 
        {
            SpawnPlatformTile();
        }
    }

    private void SpawnPlatformTile()
    {
        Instantiate(_platformTemplate, transform.forward * _spawnPosition, transform.rotation);
        _spawnPosition += _tileLength;
    }
}
