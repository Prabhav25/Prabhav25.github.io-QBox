using UnityEngine;

public class PlayerMovement : MonoBehaviour  //for player movement
{
    public Rigidbody rigbod; //so Rigidbody is a component in our game , so by doing this a rigbod will be created inside Player Movement component in unity, so we drag the Rigidbody component inside rigbod in unity, so it means whenever we write rigbod then it will refer to component Rigidbody in unity.

    public float forceForward=2000f;   //so we create a forceForward variable so by doing this a force forward will be created in the components and we can change the forward moving force from there instead of coming back to the vs code again and again.
    public float forceLeftRight=500f; //so we create a forceRight variable so by doing this a force right will be created in the components and we can change the force of the player when moving in the left or right direction from there instead of coming back to the vs code again and again.
    


    // Start is called before the first frame update
    // void Start()  so this function will run when your game starts
    // {
    //     Debug.Log("hello");
    // }

    // Update is called once per frame
    void FixedUpdate() //we used FixedUpdate here because we are calculating physics in our game like adding forces etc.
    {
        rigbod.AddForce(0,0, forceForward * Time.deltaTime);  //we add AddForce methos in Update() because we want a constant force in our game and if we add it in Start() method it will add force only at the start of the game. methodAddForce method is used to apply some force to the object in x,y,z direction so some force will be applied to our player in the game. Now we multiply with Time.deltaTime so that it evens the time in which our player will run because. It is basically the amount of time engines takes to process the previous frame. So there are fast systems also and slow systems also so what is does it makes sure that the speed remains same in the fast as well as slow systems.

        if(Input.GetKey("h")){  //to add force in right direction , Input.GetKey("h") is used to check if someone presses some key on the keyboard so if someone presses the letyter h on the keyboard then the player will move in the right direction
            rigbod.AddForce(forceLeftRight*Time.deltaTime,0,0 , ForceMode.VelocityChange);//adding force in the x direction , when the player builds momentum then it is very difficult for it to immediately shift to the negative x or positive x direction means to the left or to the right so for that we have ForceMode which allows us to specify in which direction we should add a force so we add it here when moving towards right , VelocityChange completely edits the velocity og the object ignoring its mass.
        }
        if(Input.GetKey("f")){  //to add force in left direction , Input.GetKey("h") is used to check if someone presses some key on the keyboard so if someone presses the letyter h on the keyboard then the player will move in the right direction
            rigbod.AddForce(-forceLeftRight*Time.deltaTime,0,0 , ForceMode.VelocityChange);//adding force in the negative x direction , when the player builds momentum then it is very difficult for it to immediately shift to the negative x or positive x direction means to the left or to the right so for that we have ForceMode which allows us to specify in which direction we should add a force so we add it here when moving towards left , VelocityChange completely edits the velocity og the object ignoring its mass.
        }

        if(rigbod.position.y < -1f){//so here we will check that if the player falls from the ground plane so we will do it by making sure that our y-axis goes below a certain number
            FindObjectOfType<ManageGame>().GameOver();  //so we find the object of the ManageGame and call the function GameOver , so if the player falls down then GameOver function will be called that is inside ManageGame script.
        }
    }    
}
