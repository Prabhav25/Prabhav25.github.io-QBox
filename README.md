# Extract the zip file to a folder and then play the application to experience the game. 

## Use keys "f" to move the cube left and "h" to move the cube to the right.

QBox is a game of cubes which has 4 levels and each time you clear the difficluty increases. In this game you have to move the cube with the help of keys ##f for moving to the left and ##h for moving to the right. The game gets over if your cube hits another cube or the cube falls down the plane.

Basic information about Unity :

So we have the screen view and we can zoom in and zoom out , press the right key of the moue and we can see around the scene and move our scene . On the left we will have all the (game objects) under (Hierarchy) that we have in our scene , so let's say on the left we have (main camera) as an object so when we click on that object then on the right we will see the properties related to that object called as (components) and components make objects do different things . Below the scene we have (project panel) that shows all our different game assets which we can drag in our scene and they will appear on the left where we have game objects. So when we have an object in the view and if we click key (f) then the object is focused clearly.


Now let's build our game
So in our game we are going to have 4 levels and the level difficulty becomes higher as it reaches the higher level

So let's build a level in our scene.

1) Making GROUND PLANE

So firstly we will build a ground plane for the player to stand on so for that go to Hierarchy then click on create then select 3D Object then select any object you want so i am selecting a cube , so a cube appears in our scene now to reset its position so in the right we have transform option so right click on it and select reset.  Now in our scene above at the top we can see an option of (Game) so it is the place where we can see how in reality our game is looking so what we do we just drag it to our scene so that in the left of the scene we build our game and in the right of the scene we can see how our game is looking in reality. So now we select the cube and in the components we just scale it so tht our ground plane becomes big. So we can see blue,red,green arrows so to move our object we can select these arrows and move. So it see what we have done in the scene and finally how it looks just select the scene and press (shift+spacebar).

2) Adding player(grey cube)

So to make this player more visible now we will assign material to our player so just right click in the project panel and add a material , now we can set its properties in the components panel and after setting the properties we can see our material becomes according to our set properties , now we can just drag our material and place it on our player so our player takes all the properties applies on the material.
Now we have to add some physcis in our system so when we take our player in air then it is not falling down on the ground so to add physics we just go in the right in components panel and in the below we have an option to (add component) so we click on it then we select physics then we select rigid body component so now our player falls on the ground. Now lets change the colour of the sky so to do that we will just select the Main camera then on the right we will select solid color in clear flags option and set the colour of the sky.

3)Programming(C#)

So to program in unity we create a script so just select the player then on the assets at the top then select create then select c# script so a script will be created in the project panel . Now just drag the script to the right in the components section . Now double click on the script and it will open in vs code.

4)Movement of the player(making player move)  ->  (PlayerMovement c# file)

Do it inside Player object
Till now our player was rotating but we want that our player slides on the ground and only rotates when it collides with something so basicallly player is rotating because of the friction between the ground and the player so what we do is we go in the project panel then right click then go into create and then select physic material and then it is created in the project panel now we set its dynamic,static friction to 0 in components panel.Now drag the Slip material to the ground in our scene. So inside our programming we make our player move to the left and to the right.  

5)Understanding the movement of Camera with the Player(Cube)  ->   (PlayerFollow c# file)

Do it inside Main Camera object
So here as the player moves, the camera also follow ther player so that not only player moves but the camers moves behind ther player, we do the programming for that .

6)Understanding Collision(collision with the obstacles)  ->  (CollisionPlayer c# file)

So we will add another script for it  so drag this script inside Player object inside add component , add obstacles in the scene so go to Hierarchy and right click and add a 3D object then reset its transform from the components panel then just place it , now to add colour to it so go to the project panel then right click then create then click on material so after adding material change the colour of the material and make its smoothness = 0 ,because the higher the smoothness the more light will bounce on the surface.

So there can be many objects in the scene but how to find them so we can do it with the help of tags so what to do is go in the component panel and there inside Tag add another tag and then click on + and add a tag and save now click on the Obstacle1 object on the left and then change its Tag to Obstacle in the components panel . 

Now what we want that when the player hits the obstacle then player should not move so write code for it.

7)Let's make our gameplay better

So just take the object from the Hierarchy and drop it into the projects panel so this is done whenever we want to make same type of objects , now just take the object from the projects panel and drag it to the ground in the scene , you can drag as many objects as you want. So we want that the obstacles should come immediately means out of nowhere means player should not see the obstacles earlier so for that go into lightning then inside it enable the flag and change the density.

8)Creating and showing the score and UI  ->  (Score c# file)

So sometimes it can happen that the player will pass the obstacle so to avoid that just click on the Obstacle1 in the project panel then on the right in the components panel just change the Collision Detection to Continous , do the same thing with the player.

Now to set the scores and UI , so just go to the hierarchy then right click then select UI then select text then a Text object is created inside Canvas so change the scene to 2D mode then click on the text  , download some font for the text from google fonts.Now go to Text and change its font. Now to update the text or score as the player moves so we create a new C# script (Score) , now open it in vs code and write its code.

9)Lets's create ending

So ending should be done with the help of game manager , so lets create an object so go in the Hierarchy then create an object(ManageGame) and create a C# file so it will be responsible for managing states in our game that is (Start and Stop a game),(Restart a game),(Game over screen) etc.
So we will Restart our game when we will fall of the ground plane or when we hit the obstacle .

Now lets create an obstcale that will be placed at the end when someone clears the level or when someone reaches at the end. So in order to make it invisible just disable the (Mesh Renderer) in the component panel.

Now we create a script that will communicate with the (ManageGame) to know that we have reached at the end of the level  - > (ManageGame c# file)

Now lets create an UI that will be shown when the payer wins the level. So inside canvas in the Hierarchy we create Panel UI.

So we are showing the message level complete at the end and we also want to give it some animation so we give it.

10)Now let's add some levels

So create a folder(Container) in the projects panel and in that folder we put our player , ManageGame , Main Camera , End , Canvas , Obstacle. Now we can duplicate our scenes means to create more levels and change the position of the boxes in the levels to make it more difficult level.

After completing each level he will move to the next level  -> (LevelComplete c# file)
To detect if someone has reached the end  -> (EndReached c# file)

So lets create a new scene(Accomplished) that will be loaded when a player completes all the levels. So in this scene we display the thanks message and a button to end the game  ->  (Accomplished c# file).

Now Lets create a welcome scene that will be shown when a player wants to start the game  - >  (MainScreen c# file)

11) Now in order to string all the scenes together we have to add all the scenes into the build.

12)Now we have to export our game to a platform.
