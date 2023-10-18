using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private EnemyMover _enemy;
    [SerializeField] private TargetMovement _target;

    public EnemyMover Enemy => _enemy;
    public TargetMovement Target => _target;
}
