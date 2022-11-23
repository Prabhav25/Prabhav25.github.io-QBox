using UnityEngine;
using UnityEngine.SceneManagement;   //in order to load the next scene
public class MainScreen : MonoBehaviour
{
    public void StartGame(){
        //so this function will be called whenever someone clicks on Start in order to enter into the game
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1); //so it will find the index of the current scene and then add 1 to it and then load that scene so it becomes the next scene.
    }    
}
