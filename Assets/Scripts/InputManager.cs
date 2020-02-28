using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;


public class InputManager : MonoBehaviour
{
	// Unity Header Variables for input actions
    [Header("Actions")]
    public SteamVR_Action_Boolean touch = null;
    public SteamVR_Action_Boolean press = null;
    public SteamVR_Action_Vector2 touchPosition = null;

    // Object to make
    [Header("Scene Objects")]
    public RadialMenu radialMenu = null;

    // Increments input actions by given methods
    private void Awake() {
        touch.onChange += Touch;
        press.onStateUp += PressRelease;
    	touchPosition.onAxis += Position;
    }

    // Decrements input actions by given methods
    private void OnDestroy() {
        touch.onChange -= Touch;
        press.onStateUp -= PressRelease;
    	touchPosition.onAxis -= Position;	
    }

    private void Position(SteamVR_Action_Vector2 fromAction, SteamVR_Input_Sources fromSource, Vector2 axis, Vector2 delta) {
    	radialMenu.SetTouchPosition(axis);
    }

    // Do something when touching DPAD
    private void Touch(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource, bool newState) {
    	radialMenu.Show(newState);
    }

    // Do something when pressing and releasing DPAD button
    private void PressRelease(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource) {
    	radialMenu.ActivateHighlightedSection();
    }

}
