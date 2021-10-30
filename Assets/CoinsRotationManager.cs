using UnityEngine;

public class CoinsRotationManager : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 90f;

    private CoinComponent[] coins;
    void Start()
    {
        coins = FindObjectsOfType<CoinComponent>();
    }

    // Update is called once per frame
    void Update()
    {
        foreach (var item in coins)
        {
            item.transform.Rotate(item.transform.up * rotationSpeed * Time.deltaTime);
        }
    }
}