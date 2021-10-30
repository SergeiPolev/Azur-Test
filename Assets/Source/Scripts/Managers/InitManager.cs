using UnityEngine;

[DefaultExecutionOrder(-1)]
public class InitManager : MonoBehaviour
{
    private void Start()
    {
        GameData.Instance.player = FindObjectOfType<PlayerNavMeshComponent>();
    }
}