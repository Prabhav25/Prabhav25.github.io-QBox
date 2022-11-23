using UnityEngine;
using UnityEngine.SceneManagement;   //so we use it whenevr we have to change the scene or reload the scene so like here we will reload the scene when our game will be over

public class ManageGame : MonoBehaviour
{
    //so if the player collides or player falls down then game will be over
    bool gameIsEnded = false;   //so initially we make it false

    public float  delayRestart = 2f;

    public GameObject completeLevelUI; //so we want reference to the UI so that we can enable it when we complete the level

    public void  LevelCompleted(){//it will be called when someone reached end and win the level so this function will be triggered
        completeLevelUI.SetActive(true);   //so we want to enable it so we write true

    }  

    public void GameOver(){    //so when from different scripts like from Player
        if(gameIsEnded == false){   //so initially it is set to false
            gameIsEnded = true;   //so if the player falls (PlayerMovement) or if the player collides with the obstacle(CollisionPlayer) then it will becomes true and game will be over
            Invoke("Restart" , delayRestart);  //so when our game ends then it should restart so Restart function is called, it should call after some seconds so we pass delayRestart
        }
    }

    void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name) ;//so to restart our game we have to reload our scene so we have to reload our scene that is Level1 so we do it by writing (SceneManager.GetActiveScene().name) so it returns the name of our current scene and (SceneManager.LoadScene) loads the scene 
    }
}
