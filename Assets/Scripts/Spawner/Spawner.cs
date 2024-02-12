using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject[] _objects;
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private float _secondsBetweenSpawn;

    private float _elapsedTime = 0;

    private void Update()
    {
        _elapsedTime += Time.deltaTime;

        if( _elapsedTime >= _secondsBetweenSpawn)
        {
            _elapsedTime = 0;
            
            int spawnPointNumber = Random.Range(0, _spawnPoints.Length);
            int spawnObjectNumber = Random.Range(0,_objects.Length);

            Instantiate(_objects[spawnObjectNumber], _spawnPoints[spawnPointNumber]);
        }
    }
}
