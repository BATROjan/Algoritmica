using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class CreatePrimitives : MonoBehaviour
    {
        [SerializeField] private Vector3[] points;
        [SerializeField] private Transform steeveTransform;
        
        private void Start()
        {
            foreach (var point in points)
            {
                var cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    cube.transform.position = point;
                cube.transform.SetParent(steeveTransform, false);
            }
        }
    }
}