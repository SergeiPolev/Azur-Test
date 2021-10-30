using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishManager : MonoBehaviour
{
    void Start()
    {
        GameData.Instance.player.GetComponent<OnTriggerEnterComponent>().OnEnter += Finish;

        GameData.Instance.RetryButton.onClick.AddListener(Restart);
    }

    private void Finish(Transform other, Transform @object)
    {
        if (other.CompareTag("Finish"))
        {
            GameData.Instance.FinishPanel.SetActive(true);
            GameData.Instance.IsFinished = true;
        }
    }
    private void Restart()
    {
        SceneManager.LoadScene(0);
    }
}