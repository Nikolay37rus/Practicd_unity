using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField]
    private Transform _transformObjact;


        [SerializeField]
        private Vector3 _vectorFirst;

    [SerializeField]
    private float _speed = 1;
    
    
    private void Update()
    {
        transform.Rotate(_vectorFirst * _speed * Time.deltaTime);
    }
}
