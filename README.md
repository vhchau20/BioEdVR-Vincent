# BioEdVR
Developed by Clair Ma, Lily Steiner, Vincent Chau\
Advised by Alex Shin, Jeanne Vu

## Description
BioEdVR serves as an educational VR application that allows users to interact\
with a structural model of a human cell, including but not limited to the\
nucleus, mitochondria, spindles, and centrioles. Our hope for this project\
was to help foster a new era of biological education in which students and\
scholars can interact with various types of biological systems

## Modifying any files
@Lily and @Clair, please run
```bash
git branch NAME
git checkout NAME
git status
```
Make sure you're in your branch to avoid conflicts. We'll merge everything\
right before the showcase. Also check on github.com/TritonXR/BioEdVR to see\
if your commits were actually pushed into the remote

To save to your branch, please run
```bash
git add .
git commit -m "DETAILED MESSAGE OF WHAT YOU DID"
git push origin <BRANCH_NAME>
```
Please don't push to master

## To Do List (feel free to edit this)
1. Implement highlights for 'touch' gesture on radial menu
	a. Do so by creating copy of "pod" surrounding cell part and attach\
		"hoverHighlight" material
2. Integrate pop-ups to radial menu
	a. So in the radialMenu gameobject, add (+) a new object under "Top",\
		"Right","Left","Bottom" and drag the popup to the target of that\
		object. Set the function to CellChanger:toggleActive(), which will
		do the rest
3. Fix Translucent <-> Original
4. Add sound-bytes/lofiBiologyMusic? (idk I thought this be fun to do lol)
5. Better commenting on InputManager.cs, Pointer.cs, RadialMenu.cs, Teleporter.cs
