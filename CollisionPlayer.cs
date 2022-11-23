using UnityEngine;

public class CollisionPlayer : MonoBehaviour
{
    public PlayerMovement stopMovement;  //so we make a variable to stop the movement of player when it hits thre obstacle so we will see a Stop Movement component created inside the component panel, so drag the PlayerMovement script into the Stop Movement inside conponents layer.


    void OnCollisionEnter (Collision InfoCollision ){ //so unity has created a specific function for the collidion of two ojects , so we have inside () Collision so by writing this the unity comes to know that we want to gather some information abouty the collision and then we give some name to information InfoCollision
        if(InfoCollision.collider.tag == "Obstacle"){//so we have set a tag to the obstacle.
            stopMovement.enabled=false;   //so we set it false so that when the player hits the obstacle then the player does not move

            FindObjectOfType<ManageGame>().GameOver();//so we search for the GameManage when we want it and if the collision takes place then GameOver function will be called that is inside ManageGame script

        }
    }
}
