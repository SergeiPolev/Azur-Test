using UnityEngine;
using UnityEngine.AI;

public class PlayerMovementManager : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private float sensitivity = 2f;

    private NavMeshAgent playerNavMesh;

    private Vector3 prevMousePos;

    void Start()
    {
        playerNavMesh = GameData.Instance.player.GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (GameData.Instance.IsFinished)
        {
            return;
        }

        if (Input.GetMouseButtonDown(0))
        {
            prevMousePos = Input.mousePosition;
        }
        else if (Input.GetMouseButton(0))
        {
            var delta = (prevMousePos - Input.mousePosition).normalized;

            delta.y = 0;
            playerNavMesh.Move((playerNavMesh.transform.forward - delta * sensitivity) * speed * Time.deltaTime);

            prevMousePos = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {

        }
    }
}