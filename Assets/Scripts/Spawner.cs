
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private SpawnPoint[] _spawnPoints;

    private float _spawnDelay = 2f;

    private void Start()
    {
        StartCoroutine(EnemySpawn());
    }

    private IEnumerator EnemySpawn()
    {
        var delay = new WaitForSeconds(_spawnDelay);

        while (true)
        {
            yield return delay; 

            var spawnPoint = Random.Range(0, _spawnPoints.Length);
            
            EnemyMover enemy = Instantiate(_spawnPoints[spawnPoint].Enemy, _spawnPoints[spawnPoint].transform.position, Quaternion.identity);

            enemy.SetTarget(_spawnPoints[spawnPoint].Target.transform);
        }
    }
}
