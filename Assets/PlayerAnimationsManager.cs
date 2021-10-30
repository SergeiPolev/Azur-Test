
using UnityEngine;

public class PlayerAnimationsManager : MonoBehaviour
{
    private Animator playerAnimator;

    private void Start()
    {
        playerAnimator = FindObjectOfType<PlayerAnimatorComponent>().GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            playerAnimator.SetBool("Run", true);
        }
        else if (Input.GetMouseButtonUp(0) || GameData.Instance.IsFinished)
        {
            playerAnimator.SetBool("Run", false);
        }
    }
}