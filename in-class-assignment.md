#### Useful scene shortcuts:
- **W**: Move tool
- **E**: Rotate tool
- **R**: Scale tool
- **T**: Rect tool
- **Ctrl/Cmd + D**: Duplicate selected object(s)
- **Ctrl/Cmd + S**: Save the current scene
- **LMB**: Select objects, components, values, etc.
- **RMB**: Orbit around point
- **MMB**: Pan the view
- **Ctrl/Cmd + Shift + S**: Save the current project
- **F**: Focus on the selected object
- **Alt + RMB**: Zoom in and out


### ex1: Scripts: Implementing a smarter AI opponent
<!-- Perhaps remove first part or better, do this in class -->
1. Understand the DumbAI
    - Select the Enemy game object and find the Dumb AI script.
    - Open it by double-clicking on the Script entry or using "…" and selecting `Edit Script`.
    - Why is movement written in `FixedUpdate()` as opposed to `Update()`?
    - How is moving in a straight-line and bouncing off walls implemented? 
2. Implementing GreedyAI
    - Remove the DumbAI script from the Enemy object via `"…" > Remove Component`.
    - In the Project window, navigate to `Assets/Scripts` and attach the GreedyAI script to the Enemy, then open it.
    - Fill out the TODOs in `GreedyAI.cs` to make the Enemy track the position of the ball, and move back to a central position after hitting the ball. 
3. Save the file and save the scene, then play the game to check your solution.


### ex2: Prefabs: Spawning powerups midgame
1. Create the speedboost powerup game object which we want to save as a prefab.
    - Right-click in the Hierarchy window and select `3D Object > Plane`. This will create a new game object.
    - Rename this game object to "Speedboost".
    - In the Inspector window assign the Tag "Speedboost" to this game object.
    - Use the Rect tool (Shortcut: T) to shape the object. Alternatively, set the scale values in the Transform component e.g. x:0.1 y:1 z:0.15 work well.
    - In the Mesh Collider component, enable "Convex" and "Is Trigger" options
    - Optionally if you cloned all submodules, change the appearance of the powerup by selecting a new material element `Mesh Renderer > Materials > ⦿`. (Note that debug materials are not rendered in game view.) 
2. Create storage  `Assets/Prefabs`.
    - In the Project window, right-click and select `Create > Folder`, and name it "Prefabs".
3. Save the speedboost powerup as a prefab.
    - Drag the speedboost game object from the Hierarchy window to the `Assets/Prefabs` folder in the Project window. Et voilà, we created a new prefab.
    - Delete the peedboost game object from the Hierarchy.
4. Set up powerup spawning.
    - Create an empty game object, name it "Spawner" and attach the Spawner.cs to it.
    - Select the Spawner object, which has a Spawner script attached to it.
    - Drag the speedboost prefab onto the field "Speedboost Prefab" of the Spawner script in the Inspector.
    - Now open `Spawner.cs` and uncomment the line`Instantiate(speedboostPrefab, ...)`.
6. Save your file changes and your scene changes, and play the game.
