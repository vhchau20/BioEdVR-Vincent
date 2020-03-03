## To Do List (feel free to edit this)
2. Integrate pop-ups to radial menu\
	a. Make Popups (4 in total) and place under Left Hand of Camera Rig
	b. Reset its positions to match the radial menu (ie Rotation X = 90, etc)
	c. Set off INACTIVE at first
	d. Drag CellChanger.cs Script to all 4 popups (located under Assets/Scripts)
	e. Go to RadialMenu object in Camera Rig Left Hand
		a. For each of the 4 buttons (Top,Bottom,Left,Right), Add all 4 popups
		b. Set its target to each of the 4 popups, and for the one that is
			supposed to show, set function to CellChanger:Show() and the others
			as CellChanger:Hide()
			For example, for Top, which is for nucleus, the list total should be
			8 (or 9 if you include the cellPod), and nucleus should be set to
			Show() and everything else set to Hide()
	f. Test it out

# BioEdVR
Developed by Clair Ma, Lily Steiner, Vincent Chau\
Advised by Alex Shin, Jeanne Vu

## Description
BioEdVR serves as an educational VR application that allows users to interact
with a structural model of a human cell, including but not limited to the
nucleus, mitochondria, spindles, and centrioles. Our hope for this project
was to help foster a new era of biological education in which students and
scholars can interact with various types of biological systems

## Modifying any files
@Lily and @Clair, please run
```bash
git branch NAME
git checkout NAME
git status
```
Make sure you're in your branch to avoid conflicts. We'll merge everything
right before the showcase. Also check on github.com/TritonXR/BioEdVR to see
if your commits were actually pushed into the remote

To save to your branch, please run
```bash
git add .
git commit -m "DETAILED MESSAGE OF WHAT YOU DID"
git push origin <BRANCH_NAME>
```
Please don't push to master


