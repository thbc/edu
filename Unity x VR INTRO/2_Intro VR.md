# Intro to VR

&nbsp;

# Use Cases

- Interactive experiences
- 360-video
- Data exploration / visualisation
- Planning & engineering
- Simulations
- Studies & experiments
- …

# Setup

## 1\. Creating a Meta Developer Profile

- Begin by downloading the Oculus app onto your smartphone or tablet using the respective links for [Android](https://play.google.com/store/apps/details?id=com.oculus.twilight&pli=1) or [iOS](https://apps.apple.com/us/app/meta-quest/id1366478176).
- Log into the app using your Meta developer credentials. \*Should you not possess a developer account, please register to become an Oculus developer. For first-time logins, proceed as directed to create your VR profile.
- Connect your VR headset with the app and carry out the setup process as guided.

For additional information on setting up your Meta Quest, visit: [Getting started with your Meta Quest](https://www.meta.com/en-gb/help/quest/articles/getting-started/getting-started-with-quest-2/)

## 2\. Configuration for Oculus / Meta Quest 2

- After accessing your account, navigate on your headset to: Settings > System > Developer
- Enable the USB Connection Dialog feature.
- In the Oculus mobile application, proceed to: Devices > Developer Mode
- Switch on Developer Mode using the provided toggle.
- Link your headset to your computer with a USB-C cable.

&nbsp;

## 3\. Linking Quest with Unity

- Launch your project within Unity.
- Edit > Project Settings -> XR Plug-in Management.
- Within the Android Settings section, ensure Oculus is selected.
- Navigate to: File > Build Settings
- Choose Android as your platform and select 'Switch Platform'.
- From the Run Device dropdown, select your device. If it doesn't appear, confirm that Developer Mode is on and click 'Refresh'.
- To commence the build and run process, click 'Build and Run'."

&nbsp;

* * *

# VR pipeline in Unity (theory)

- Device platform:  
    e.g. Android for MetaQuest, Windows for VivePro, …
- XR Plugin Provider:  
    e.g. OpenXR for standardized SDK, ARCore for Google’s AR SDK,  
    Oculus for proprietary SDK
- OpenXR Settings:  
    add profiles for each device to support

<img src="../_resources/Picture1-2.png" alt="Picture1.png" width="250" height="230" class="jop-noMdConv"> <img src="../_resources/Picture3-2.png" alt="Picture3.png" width="561" height="235" class="jop-noMdConv"><img src="../_resources/Picture2-2.png" alt="Picture2.png" width="231" height="227" class="jop-noMdConv">

&nbsp;

&nbsp;

# OpenXR

“OpenXR in Unity serves as a bridge between Unity applications and various VR/AR platforms, enabling developers to create XR experiences that can run on multiple XR devices without needing to rewrite code for each device or platform. It is an open, royalty-free standard for cross-platform VR and AR development, created by the Khronos Group. OpenXR simplifies the development process, reduces fragmentation, and ensures better compatibility across different XR devices.“

&nbsp;

<img src="../_resources/Picture7-2.png" alt="Picture7.png" width="632" height="387" class="jop-noMdConv">

&nbsp;

<img src="../_resources/Picture8-2.png" alt="Picture8.png" width="633" height="383" class="jop-noMdConv">

&nbsp;

<img src="../_resources/Picture9-2.png" alt="Picture9.png" width="633" height="263" class="jop-noMdConv">

* * *

<img src="../_resources/9ae2d23232ff67d252508f30f13b3ea7-2.png" alt="9ae2d23232ff67d252508f30f13b3ea7.png" width="730" height="520" class="jop-noMdConv">

* * *

&nbsp;<img src="../_resources/14d3c70131595e485004aa17ac0280e8-2.png" alt="14d3c70131595e485004aa17ac0280e8.png" width="730" height="500" class="jop-noMdConv">

* * *

<img src="../_resources/cb9d9a120193b1cc710998552fa04173-2.png" alt="cb9d9a120193b1cc710998552fa04173.png" width="728" height="663" class="jop-noMdConv">

* * *

<img src="../_resources/58439500ac0fe9bc69f17f47f692628e-2.png" alt="58439500ac0fe9bc69f17f47f692628e.png" width="728" height="661" class="jop-noMdConv">

&nbsp;

# Locomotion - Turning

Choose either one:

- Snap Turn Provider:  
    turns player around by certain amount of degrees
- Continuous Turn Provider:  
    turns player around continuously while pressing the joystick  
    <img src="../_resources/2305dd5f39596e44dce535435f702ae8-2.png" alt="2305dd5f39596e44dce535435f702ae8.png" width="483" height="653" class="jop-noMdConv">

&nbsp;

# Interactables

- Components for executing functions, based on interaction events
- E.g.: hovering is triggered from moving controller over the object. Select is triggered when selection button is pressed while hovering

<img src="../_resources/a879dfa57ac3deb3958d836166bb0a03-2.png" alt="a879dfa57ac3deb3958d836166bb0a03.png" width="554" height="619" class="jop-noMdConv"> <img src="../_resources/53dfa9d65905a869d6d9cf2377c4ed0e-2.png" alt="53dfa9d65905a869d6d9cf2377c4ed0e.png" width="552" height="410" class="jop-noMdConv">

&nbsp;

# Interactables - Simple Interactable

- Basic objects used for triggering events, e.g. via gaze or button interactions

<img src="../_resources/972ed2f74dcc94188ea670dd8cd46a2d-2.png" alt="972ed2f74dcc94188ea670dd8cd46a2d.png" width="395" height="871" class="jop-noMdConv">

&nbsp;

# Interactables - Grab Interactable

- Direct and physical form of interacting with virtual objects, e.g. for picking them up, rotating or scaling them

![0612874cd86dc258ba579564efa2bc8c.png](../_resources/0612874cd86dc258ba579564efa2bc8c-2.png)

<img src="../_resources/e88abb6ef26b7f88a68d8efe785e0ca2-2.png" alt="e88abb6ef26b7f88a68d8efe785e0ca2.png" width="707" height="203" class="jop-noMdConv">