using TMPro;
using UnityEngine;
using UnityEngine.UI;

[DefaultExecutionOrder(-2)]
public class GameData: MonoBehaviour
{
    private static GameData game;
    public static GameData Instance { get { return game; } }

    public PlayerNavMeshComponent player;
    public GameObject FinishPanel;
    public Button RetryButton;
    public Image ProgressFill;
    public TextMeshProUGUI CoinsText;

    public bool IsFinished = false;

    void Awake()
    {
        game = this;
        IsFinished = false;
    }

}