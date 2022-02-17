using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManage gameManage;
    void OnTriggerEnter()
    {
        gameManage.CompleteLevel();
    }
}
