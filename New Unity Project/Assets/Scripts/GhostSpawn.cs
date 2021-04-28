using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostSpawn : MonoBehaviour
{
    [SerializeField]
    private GameObject _ghost;

    [SerializeField]
    private Transform _spawnPoint;
    void Start()
    {
        Instantiate(_ghost, _spawnPoint.position, Quaternion.identity);
    }

    
    void Update()
    {
        
    }
}
