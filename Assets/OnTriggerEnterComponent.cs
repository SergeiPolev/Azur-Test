using System;
using UnityEngine;

public class OnTriggerEnterComponent : MonoBehaviour
{
    public Action<Transform, Transform> OnEnter;

    private void OnTriggerEnter(Collider other)
    {
        OnEnter?.Invoke(other.transform, transform);
    }
}