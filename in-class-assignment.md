### Before TODO
- `git stash`
- `git checkout dp-toolkit-assignment`
- `git submodule update --init –-recursive`


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


### ex1: Introduce object
1. attach `GameManager.cs` to `panto` game object
2. open the `GameManager.cs` file to see its source code. Do `TODO 1` and `TODO 2`. These TODOs require you to comment out code. If you don't do this nothing will happen!
3. add `Ball`, `Enemy`, `Player` prefabs, and  each position game object from the scene hierarchy to `GameManager`
4. input your COM port to `panto` game object's `Dual Panto Sync`
5. connect to dualpanto and press play in the unity editor

### ex2: mapping me handle
1. attach `MeHandle.cs` to `Player` *prefab* game object
2. press play in the unity editor and try to control

### ex3: mapping it handle
1. open `GameManager.cs` and find `TODO 3`
2. connect to dualpanto and press play in the unity editor

### ex4: rendering wall
1. activate `PlayerWall` game object at unity editor inside the scene hierarchy 
2. open `GameManager.cs` and find `TODO 4`

### ex5: haptic feedback
1. attach `Recoil.cs` to the `Player` prefab game object

