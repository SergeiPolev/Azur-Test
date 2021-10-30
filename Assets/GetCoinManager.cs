using UnityEngine;

public class GetCoinManager : MonoBehaviour
{
    [SerializeField] private GameObject vfx;

    private float coins;

    private const string savekey = "coins";
    void Start()
    {
        if (PlayerPrefs.HasKey(savekey))
        {
            coins = PlayerPrefs.GetFloat(savekey);
        }
        else
        {
            coins = 0f;
        }

        GameData.Instance.CoinsText.text = coins.ToString();
        GameData.Instance.player.GetComponent<OnTriggerEnterComponent>().OnEnter += GetCoin;
    }

    private void GetCoin(Transform other, Transform @object)
    {
        if (other.CompareTag("Coin"))
        {
            coins++;
            GameData.Instance.CoinsText.text = coins.ToString();

            other.gameObject.SetActive(false);

            Destroy(Instantiate(vfx, other.transform.position, Quaternion.identity), 2f);

            Save();
        }
    }
    private void Save()
    {
        PlayerPrefs.SetFloat(savekey, coins);
    }
}