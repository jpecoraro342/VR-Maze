# MazeVR

- **[Video Demo](#video-demo)**
- **[Motivation](#motivation)**
- **[Description](#description)**
- **[Technical Explanation](#technical-explanation)**
- **[Controls](#controls)**
- **[Installation Instructions](#installation-instructions)**
- **[Gameplay Notes](#gameplay-notes)**
- **[Resources](#resources)**

### Video Demo

### Motivation

MazeVR brings virtual reality to the classic maze environment. Mazes in real life are fun and exciting. It is immersive to be lost in a maze, and feel the need to find your way out. Maze games are traditionally much less exciting. Even though there may be cool graphics and props, the feeling of being lost doesn't exist in a traditional virtual maze. MazeVR seeks to change this by putting the user in a virtual maze environment. The sense of immersion isn't lost when users are transported into MazeVR.

### Description

MazeVR is a virtual maze environment for google cardboard. The goal is to make it to the end of the maze. This demo consists of three different levels.

 - level one: Sci-Fi (Fai Kwok)
 - level two: Outdoor Adventure (Craig Lu)
 - level three: Medieval Dungeon (Joseph Pecoraro)
 
Once each level is completed, the user is teleported to the following level. As stated previously, this is designed to be an immersive experience. There are various props on each of the levels to add to this factor.

### Technical Explanation

The project for the VR Maze, was created to give users an experience in a virtual environment that allows them to interact and feel immersed in a series of mazes where they have to find a way out. The pure technical components we used were Unity, Google Cardboard, Assets from the Unity Assets store, and various scripts we found online. A couple of techniques we tried, in attempt to give the users a good experience, was decorating the environment with objects such as a giant robot, an animated horse, and a dragon. Along with objects, we also added in 3D audio to provide the users some guidance through the maze.


### Controls

Maze VR uses gaze based input, as well as the button on google cardboard

- Walk: Press the button on google cardboard to toggle walking.
- Look Around: Turn your head all different ways to explore the virtual world.
- Selection: Press the button on google cardboard to select menu items.

### Installation Instructions

MazeVR is open source! That means that you can view the source on [github](https://github.com/jpecoraro342/VR-Maze). MazeVR Code+APK bundle is also available at [this link](https://onedrive.live.com/redir?resid=D449DAF21E6536F7%2158536&authkey=%21ADBvta888rfW-a4&ithint=file%2Crar).

**Android**

1. Download the apk at [this link](VR-Maze.apk).
2. Install like any other android apk.
3. Play on your phone with google cardboard!

**iOS**

*note: iOS apps must be code signed, which means until the application is available in the appstore, it can only be put on an iOS device manually.*

1. Download the source code at [github](https://github.com/jpecoraro342/VR-Maze).
2. Build for iOS
3. Open the generated project in XCode
4. In the project settings
    - set enable bitcode: no
    - add MessageUI.framework
    - add Security.framework
5. Build and run.

### Gameplay Notes

Unfortunately, this game is not perfect. It was made in a short amount of time, and so there are bugs and glitches. Here are soe things to be aware of when playing this game.

- Long level load times: When switching between levels, it takes a very long time to load. You may not think it is loading, but don't worry, it is.
- Possible collision issues on first level: You shouldn't be able to walk through any walls, and you can't. There might just be a small chance that you can with a couple walls though.
- Performance issues: The third level has some notable performance issues. It runs well on high end phones, but there is a frame rate drop when looking around a lot. It may lead to increased chance of motion sickness, but other than that it should be fine. 

### References

**Level One**

- https://www.assetstore.unity3d.com/en/#!/content/2088
- https://github.com/JuppOtto/Google-Cardboard/
- https://www.assetstore.unity3d.com/en/#!/content/25255
- https://www.assetstore.unity3d.com/en/#!/content/6411
- https://www.assetstore.unity3d.com/en/#!/content/44185
- http://www.memecenter.com/fun/4261085/was-watching-the-maze-runner-when-i-suddenly-realised
- https://c1.staticflickr.com/3/2507/4061959450_ddb0aaab38.jpg
- http://screencrush.com/442/files/2015/10/star-wars-posters-pic.jpg?w=1600&cdnnode=1
- https://s-media-cache-ak0.pinimg.com/736x/23/28/5d/23285d1d6022cc91ea58719c62ee650c.jpg
- http://screenrant.com/wp-content/uploads/Darth-Vader-voiced-by-Arnold-Schwarzenegger.jpg
- http://cdn.funzypics.com//Thumbnails/3/19340-Keep-Calm-And-Use-The-Force---Luke.jpg
- http://weknowmemes.com/wp-content/uploads/2013/10/jaden-smith-tweets-15.jpg
- http://memesvault.com/wp-content/uploads/Lol-Meme-01.jpg
- http://hacktext.com/seo201/lib/imgs/darth-vader-force-choke.jpg
- https://www.assetstore.unity3d.com/en/#!/content/33469
- http://9gag.com/gag/aQ8eD52
- http://9gag.com/gag/arK56oB
- http://9gag.com/gag/a2m4wXw
- http://9gag.com/gag/avP7xrE
- https://github.com/JuppOtto/Google-Cardboard
- https://www.assetstore.unity3d.com/en/#!/content/38694
- https://www.assetstore.unity3d.com/en/#!/content/21813
- https://gist.github.com/NovaSurfer/5f14e9153e7a2a07d7c5

**Level Two**

- https://www.assetstore.unity3d.com/en/#!/content/12567
- https://www.assetstore.unity3d.com/en/#!/content/27594
- https://www.assetstore.unity3d.com/en/#!/content/24923
- https://www.assetstore.unity3d.com/en/#!/content/16687
- https://www.assetstore.unity3d.com/en/#!/content/52977
- https://www.assetstore.unity3d.com/en/#!/content/3930
- https://www.assetstore.unity3d.com/en/#!/content/19032
- https://www.assetstore.unity3d.com/en/#!/content/851
- https://www.assetstore.unity3d.com/en/#!/content/38272

**Level Three**

- https://3dwarehouse.sketchup.com/model.html?id=aa2c6543e2767d60bd9380156189de87
- https://www.assetstore.unity3d.com/en/#!/content/30232
- https://www.assetstore.unity3d.com/en/#!/content/38689
- https://www.assetstore.unity3d.com/en/#!/content/41540