using UnityEngine;


public class EndReached : MonoBehaviour
{
    public ManageGame gameManage;

    void OnTriggerEnter(){//to to detect if someone has reached the end or when it reached the end then it triggers so for that we have OnTriggerEnter
        gameManage.LevelCompleted();   //as the player reaches the end and wins then LevelCompleted function will be called that is inside ManageGame
    }
}    
