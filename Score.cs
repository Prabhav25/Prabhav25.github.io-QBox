using UnityEngine;
using UnityEngine.UI;   //as we have to write code for the user interface
using TMPro;
public class Score : MonoBehaviour
{
    public Transform playerPosition;   //as we want the position of the player so we write compoent Transform as Transform component is responsible for the position , rotation and scale

    public TMP_Text scoreText; 
    // Update is called once per frame
    void Update()
    {
        scoreText=GetComponent<TMP_Text>();
        scoreText.text = playerPosition.position.z.ToString("0"); //so our text will change acoording to the player's position , so we write 0 because we only want that the score of the distance covered by the player should be not in decimal number.
    }
}
