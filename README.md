# MovieSet
A project repository for Indietopia internship 1 week assignment.

# Location and explanation of files
[Executable file](https://drive.google.com/drive/folders/1yqZXosKvQbxHpTi7s-t5upYBeOnaE3U4?usp=sharing) in Google Drive.

The github contains all Unity development files in IndietopiaIntern folder.

# Timeline of design choices (with explanations)
Going further, I am going to use this markdown document to write out my choices and workflow during the creation of this project.

## Defining the problem/task

### Task
First I define a task based on the given assignment description. In this case the task is to **"Create a new project in Unity"** with key points being:
1. utilize external assets, your own assets -> develop a small scene with environmental storytelling in any appropriate topic of interest.
2. add a win condition -> pickups, player interactions, or checkpoints.

In addition to that, feedback in forms of visuals or sound is to be added upon completion.

### Task specifics
 - Project must be in a github repository.
 - Clean and easily understandable project structure and code.

## Idea definition
Since I am a movie fan I have decided to create this project by showing off my 3 favorite movies.

Each movie is dedicated a seperate room going from my third favorite to favorite.   

1. Imitation Game
2. Dune
3. Interstellar

Above you can see the order of rooms themes I am going to try to create using publicly free assets.

Player will press a button next to the door to navigate to the next room.
Win condition is to walk through all the rooms and reach the final room.

## Specifications
I am going to use a mix of low and high poly assets from Unity Marketplace.

## Timeline

### Starting out
I started with a simple prototype of the main features that the game requires, movement, camera movement and a simple test scene.

![Movement Prototyping](/README%20Screenshots/Prototyping%20Movement%20of%20character.png)

### Space
After developing simple camera and character movement I continued into Blender to make a simple dark room to use for each movie showcase space.

![Dark Room](/README%20Screenshots/Creation%20of%20first%20room.png)

### World building
After that I build the entirety of the skeleton of the world, 3 rooms for movie showcase, one load-in room and the final exit room.

![Dark Room](/README%20Screenshots/Laying%20out%20the%20rooms%20for%20each%20movie.png)

### Design choices
The world is linear, there are 4 doors to open using a button.

Each room follows similar structure with the picture frame to the left being the movie name and pictures to the right being some screenshots from the movie.

Each room also consist of some environmental or expositional pieces to show of the theme of the room. 

Due to rooms being the same structure the player knows what to expect from the next room.

Each button has a sound and a particle (visual) cue that it has been pressed.

### User testing
I got my girlfriend to test the game (experience).

The main improvement takeaways were:

1. Button particles looked like fire (unrelated to the idea of the game)
2. The Dune room was bland and it needs something more to represent it