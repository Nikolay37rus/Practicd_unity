using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookRotation : MonoBehaviour
{
    [SerializeField]
    private Transform _transformObject;

    [SerializeField]
    private float _speed = 1;
    
   

   
    void Update()
    {
        var relativePosition = _transformObject.position - transform.position;
        var rotation = Quaternion.LookRotation(relativePosition);
        transform.rotation = rotation;

    }
}
