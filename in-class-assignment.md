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

### Prefabs: Spawning powerups midgame
1. Create the speedboost powerup game object which we want to save as a prefab.
    - Right-click in the Hierarchy window and select `3D Object > Plane`. This will create a new game object.
    - Rename this game object to "Speedboost".
    - In the Inspector window assign the Tag "Speedboost" to this game object.
    - Use the Rect tool (Shortcut: T) to shape the object. Alternatively, set the scale values in the Transform component e.g. x:0.1 y:1 z:0.15 work well.
    - In the Mesh Collider component, enable "Convex" and "Is Trigger" options
2. Create storage  `Assets/Prefabs`.
    - In the Project window, right-click and select `Create > Folder`, and name it "Prefabs".
3. Save the speedboost powerup as a prefab.
    - Drag the speedboost game object from the Hierarchy window to the `Assets/Prefabs` folder in the Project window. Et voilà, we created a new prefab.
    - Delete the peedboost game object from the Hierarchy.
4. Set up powerup spawning.
    - Select the Spawner object, which has a Spawner script attached to it.
    - Drag the speedboost prefab onto the field "Speedboost Prefab" of the Spawner script in the Inspector.
    - Now open `Spawner.cs` and uncomment the line`Instantiate(speedboostPrefab, ...)`.