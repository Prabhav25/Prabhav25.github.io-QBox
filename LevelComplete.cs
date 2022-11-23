using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelComplete : MonoBehaviour
{
    public void NextLevelLoading(){   //so in animation we have set it to 2 seconds and whenever our game is over then after two seconds it is going to load the game again
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //as we want to load the next scene after reaching the end so in order to do that we have to firstly know the build index of the current scene so for that go to File then to Build Settings so here e can see our scene Level1 and its build index is 0 so in order to load the next scene we have to add 1.
    }
}
