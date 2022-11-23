using UnityEngine;
  
public class PlayerFollow : MonoBehaviour   //so when the player will move the camera will also move means when the player move then camers should also follow the player so it basically to know the position of the player within each second
{
    public Transform player;   //so inside components in unity we have Transform component and we name it as player so by doing this we can see a player component inside component panel. So by writing Transform here we can get a link to the player's information about its position,rotation and scale. Now from the left object panel just drag the player object to the player component in the component panel , so now whenever we write player in our code it means it refers to that object.

    public Vector3 offset;   //Vector3 stores three floats and it is very useful for x,y,z vectors. So we will see position as the component below player component in the conponnt panel , so now there we want to remain centered at the x so we keep it 0 , we set y=1 as we want to lift it , we also want to pull it back so we keep z=-5 , we are setting the position of the camera so when the player moves then how will the camera move behind it means what will be its position.

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;    //transform means the transform attached to the game object or player and position is the position of the player  , so this whole statement means that the camera's position is set to the player's position and camera will move with the player , now we add offset here so that camera remains behind the player.
    }
}
