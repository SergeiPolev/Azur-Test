using UnityEngine;

public class ProgressBarManager : MonoBehaviour
{
    private Vector3 startPosition;

    private float totalDistance;
    void Start()
    {
        GameData.Instance.ProgressFill.fillAmount = 0;
        var finish = FindObjectOfType<FinishComponent>();
        startPosition = GameData.Instance.player.transform.position;

        totalDistance = Vector3.Distance(GameData.Instance.player.transform.position, finish.transform.position);
    }

    void Update()
    {
        GameData.Instance.ProgressFill.fillAmount = Vector3.Distance(GameData.Instance.player.transform.position, startPosition) / totalDistance;
    }
}