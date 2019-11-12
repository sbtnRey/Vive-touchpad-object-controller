# Vive-touchpad-object-controller
This is a script to allow one to control the movement of an object with the touchpad on a vive controller and control the rotation of the object with the direction in which one looks.

## Build instructions
Built using Unity 2019.2.8

### Prerequisites
* HTC Vive (HardWare)
* [SteamVR Plugin](https://assetstore.unity.com/packages/templates/systems/steamvr-plugin-32647)

## Setup
1. Import the latest SteamVR plugin from the Unity and add the "[Camera Rig]" and "[SteamVR]" prefab to the scene.

2. Setup a new SteamVR Input Action: Window -> SteamVR Action.
Create a new action (I called mine "TouchpadTouch"), set the type to 'vector2' and then click "Open binding UI".
![Alt text](SteamVR%20Input.png?raw=true "Optional Title")

3. Click "Edit" for the current binding, Under "TrackPad" edit the position field and put in the vector2 "touchpadtouch" binding that was previously made and click "Save Personal Binding".
![Alt text](SteamVR%20Binding.png?raw=true "Optional Title")

After click "Save and Generate" in the SteamVR input menu.

4. Finally just add the script to the object that you want to control.
![Alt text](https://cdn.discordapp.com/attachments/497874524549808128/641586817916731402/ex.gif "Optional title")

## Author

**Sebastian Reynolds**

Contact: **sbtn.rey@gmail.com**


