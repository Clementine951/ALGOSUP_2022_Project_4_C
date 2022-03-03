# Technical Specification

## Table of contents

- [1. Introduction](#1-introduction)

- [2. Team](#2-team)

- [3. Development rules](#3-development-rules)

- [4. Assets Used](#4-assets-used)

- [5. VR compatibility](#5-vr-compatibility)

- [6. Possible issues](#6-possible-issues)

- [7. Version 2.0 ](#7-version-2)

## 1. Introduction

The purpose of this project is to create a virtual school of B3 in 3D, the future premises of ALGOSUP. The ultimate goal of this project is to be able to visit with a virtual reality headset (Oculus Quest 2) and to be able to test all possible movement problems to adapt the layout of the building before moving in. The virtual configuration should be as close as possible to the real configuration.


## 2. Team

We are currently a team of 5.

-   **Clémentine Curel**  Project Manager
-   **Malo Archimbaud**  Technical Leader
-   **Elise Gautier**  Contributor
-   **Salaheddine Namir**  Contributor
-   **Victor Leroy**  Contributor


## 3. Development rules

### Technologies used

Although C# is the best language to works with Unity. 

#### Type of needs

| What?  | Which? | Why? |
|:--------------- |:---------------|:---------------|
| Code editor      | Any ( Visual Studio Code Community advised) | Easier for C#|
| Github | [Repository](https://github.com/Clementine951/ALGOSUP_2022_Project_4_C) | Code |
| Trello | [Trello](https://trello.com/invite/b/tLiReKj5/08cce8057179594621b0ac6cef2c3f99/algosup2022project4c) | Project progression |
| Slack | [Slack](https://join.slack.com/t/algosup2022project4c/shared_invite/zt-13wt6eydf-aK1bf5nKa7cF6dGthjy8tA) | Project Communication |
| Unity | [Unity](https://unity.com/fr) | 3D modeling |
|Blender|[Blender](https://www.blender.org/)|Fix some slowness problem|


### Formating

| Type  | Format |
|:--------------- |:---------------:|
| Namespace | camelCase |
| Module | camelCase |
| Function  | PascalCase |
| Variable | PascalCase |

## 4. Assets Used


| Name  | Use | Link |
|:--------------- |:---------------:|:---------------:|
| Metal Floor | Will serve as a texture for the stairs of the establishment | [Metal Texture](https://assetstore.unity.com/packages/2d/textures-materials/metals/metal-floor-rust-low-texture-40351)|
| Door Free Pack Aferar | Will be placed at every room | [Door](https://assetstore.unity.com/packages/3d/props/interior/door-free-pack-aferar-148411)|
| Sci fi Access Machine | Will be placed in front of each room to secure them | [Access Pass](https://assetstore.unity.com/packages/3d/environments/sci-fi/sci-fi-access-machine-162924)|
| Yughues Free Decorative Plants | Will be used as decoration in offices, hallways... | [Plants](https://assetstore.unity.com/packages/3d/props/interior/yughues-free-decorative-plants-13283)|
| Free PBR Lamps | Will be placed throughout the infrastructure for brightness | [Lamps](https://assetstore.unity.com/packages/3d/props/interior/free-pbr-lamps-70181)|
| Ashtrays | Will be put on the terrace for smokers | [Ashtrays](https://assetstore.unity.com/packages/3d/props/interior/ashtrays-140632)|
| Japanese Rubbish Bin | Will be placed in the student lounges and the staff | [Bin](https://assetstore.unity.com/packages/3d/props/exterior/japanese-rubbish-bin-4390)|
| Retro-Modernistic Dining Chair | Will be an armchair for the student and staff lounge | [Modern Chair](https://assetstore.unity.com/packages/3d/props/furniture/retro-modernistic-dining-chair-171354)|
| Bar Chair 2 | Will be put in the student lounge for high tables | [Stool](https://assetstore.unity.com/packages/3d/props/interior/bar-chair-2-106895)|
| Snack Machines | Will be placed in the hallways as well as in the student lounge | [Snack Machines](https://assetstore.unity.com/packages/3d/props/interior/snack-machines-3517)|
| 3D Bakery Object | Will be in the student and staff lounges | [Food](https://assetstore.unity.com/packages/3d/props/food/3d-bakery-object-17167)|
| Kitchen Creation Kit | Will be used in the student and staff lounges | [Kitchen Kit](https://assetstore.unity.com/packages/3d/environments/kitchen-creation-kit-2854)|
| Plates, Bowls & Mugs Pack | Will be put in student lounges and staff | [Dishes](https://assetstore.unity.com/packages/3d/props/interior/plates-bowls-mugs-pack-146682)|
| Cutlery Silverware PBR | Will be put in the student and staff lounges | [Cutlery](https://assetstore.unity.com/packages/3d/props/food/cutlery-silverware-pbr-106932)|
| BarProps | Will be placed in student lounges and staff | [Tables](https://assetstore.unity.com/packages/3d/props/barprops-137130)|
| Kitchen Props | Will be put in student lounges and staff | [Dishes](https://assetstore.unity.com/packages/3d/props/interior/kitchen-props-free-80208)|
| HQ Modern Sofas Pack | Will be placed in the student lounge | [Sofa](https://assetstore.unity.com/packages/3d/props/furniture/hq-modern-sofas-pack-52202)|
| HDRP Interior Lighting Template | Will be used for the fridge and the sink which will be in the student lounges and the satf | [Kitchen](https://assetstore.unity.com/packages/3d/environments/hdrp-interior-lighting-template-vol-2-88464)|
| Low-Poly Table Tennis Set | Will be placed in the student lounges so that students can relax during break times | [Table Tennis](https://assetstore.unity.com/packages/3d/props/low-poly-table-tennis-set-181749)|
| Toilet Flush | Will be placed in the toilets | [Toilet](https://assetstore.unity.com/packages/audio/sound-fx/toilet-flush-free-sample-pack-144361)|
| Toilet Paper Roll | Will be placed in the toilets | [Toilet Paper](https://assetstore.unity.com/packages/3d/props/toilet-paper-roll-proto-series-165615)|
| First-Aid Set | Will be placed in the toilet | [first Aid Box](https://assetstore.unity.com/packages/3d/props/first-aid-set-160073)|
| Industrial Vacuum Cleaner | Will be put in the cleaning room | [Vacuum Cleaner](https://assetstore.unity.com/packages/3d/props/industrial/industrial-vacuum-cleaner-74888)|
| Printer Lowpoly | Will be placed in the repro room | [Printer](https://assetstore.unity.com/packages/3d/props/electronics/printer-lowpoly-4996)|
| Workplace Tools | Will be used in the robotics workshop | [Tools](https://assetstore.unity.com/packages/3d/props/industrial/workplace-tools-86242)|
| QA Books | Will be used for library | [Books](https://assetstore.unity.com/packages/3d/props/interior/qa-books-115415)|
| LowPoly Server Room Props | Will be used for the server room as well as the office for the director's office | [Server Room](https://assetstore.unity.com/packages/3d/environments/lowpoly-server-room-props-197268)|
| HQ Acoustic system | Will be placed in the amphitheater and in the student lounge | [Pregnant](https://assetstore.unity.com/packages/3d/props/electronics/hq-acoustic-system-41886)|
| Camera HQ | Will be put in the video studio room | [Camera](https://assetstore.unity.com/packages/3d/props/electronics/camera-hq-128822#description)|
| Streaming Microphone | Will be put in the video studio room | [Microphone](https://assetstore.unity.com/packages/3d/props/electronics/streaming-microphone-178137)|
| Detailed ballpoint pens | Will be in offices and stocks | [Pens](https://assetstore.unity.com/packages/3d/props/tools/detailed-ballpoint-pens-164157)|
| Office Supplies Low Poly | Will be in offices and stocks | [Stationery](https://assetstore.unity.com/packages/3d/props/office-supplies-low-poly-105519)|
| Office Room Furniture | Will be put in offices and stocks | [Office Furniture](https://assetstore.unity.com/packages/3d/props/furniture/office-room-furniture-70884)|
| School Supplies | Will be put in offices and stocks | [School Furniture](https://assetstore.unity.com/packages/3d/school-supplies-96667)|
| Garage Props Pack | Will be used for shelving to put in stock rooms and hallways | [Garage Props](https://assetstore.unity.com/packages/3d/props/industrial/garage-props-pack-132664)|
| Laptop | Will be for students in project rooms | [Computer](https://assetstore.unity.com/packages/3d/props/electronics/free-laptop-90315)|
| Trash Bin | Will be placed in each project and course room as well as in the offices | [Bin](https://assetstore.unity.com/packages/3d/props/furniture/trash-bin-96670)|
| School assets | Will be used for bulletin boards, projector and whiteboards in classrooms, project rooms, hallways and amphitheater | [School](https://assetstore.unity.com/packages/3d/environments/school-assets-146253)|
| Modern Lounge Chair 002 | Will be an armchair in any office | [Office Chair](https://assetstore.unity.com/packages/3d/modern-lounge-chair-002-52012)|
| Dublin Chair | Will be used in offices to allow visitors to be able to sit | [Visitor Chair](https://assetstore.unity.com/packages/3d/props/furniture/dublin-chair-185929)|
| DevDen ArchViz Vol 1 - Scotland URP | Will be used for decoration, project chairs, desks as well as library and repro room | [Apartment](https://assetstore.unity.com/packages/3d/environments/urban/devden-archviz-vol-1-scotland-urp-204933)|
| UnityJapanOffice | Will be used for the meeting room and the reception but also for the TVs and the air conditioning which will be in each room | [Japan Office](https://assetstore.unity.com/packages/3d/environments/unityjapanoffice-152800)|
| Clock | Will be put at the reception, in the offices as well as in the classrooms | [Clock](https://assetstore.unity.com/packages/3d/props/interior/clock-4250)|
| Low Poly Office Props | Will be used for umbrellas and tablets in front of the rooms for the timetable | [Office Props](https://assetstore.unity.com/packages/3d/environments/low-poly-office-props-lite-131438)|
| Post Box | Will be placed outside the building | [Post Box](https://assetstore.unity.com/packages/3d/post-box-9182)|
| Trophy Cups/Chalices | Will be used as decoration in the corridors during won competitions | [Trophy](https://assetstore.unity.com/packages/3d/props/trophy-cups-chalices-free-188059)|
| Office Low Poly | Will be used for the water fountain and the frame that will go in the hallways | [Office](https://assetstore.unity.com/packages/3d/environments/office-low-poly-133510)|
| Fire Extinguisher | Will be placed in front of each exit as well as close to the server room and secure stock | [Fire Extinguisher](https://assetstore.unity.com/packages/3d/props/fire-extinguisher-21147)|
| Destroyable Retro CRT Monitor Prop | Will be placed in the corridors in decoration and in museums | [Retro TV](https://assetstore.unity.com/packages/3d/props/electronics/destroyable-retro-crt-monitor-prop-157334)|
| Bicycle Pack | Will be in the room for students coming to the establishment with | [Bicycle](https://assetstore.unity.com/packages/3d/vehicles/land/free-bicycle-pack-199782)|
| Electric Scooter Prop | Will be in the room for students coming to the establishment with | [Electric Scooter](https://assetstore.unity.com/packages/3d/props/exterior/electric-scooter-prop-171335)|

## 5. VR compatibility

To enable the VR comptability on our project, we need to have the XR plugin management package installed, which can be found on the Unity website. Then, we need to go in XR plugin management in the project settings and choose what kind of VR device will be use. It is an Oculus in our project. Once that is done, we need to attach the main camera of the scene with the object which will represent the user. This can be done at the beginning or once the B3 modelisation is done.

## 6. Possible issues

### Slowness simulation

One of the most dangerous problems can be the slowness of the simulation.
To fix this problem, you can remove all the windows, doors, and furniture from the architect's file and join together all the mesh in Blender. Next, you will have to recreate them in unity.

### Delay for milestones

To avoid these problems, we have decided to not model the second floor. 
Next, the only other solution is to manage the team efficiently thanks to a project execution plan (Trello) to attribute all tasks and put deadlines.

###  Team Leaving

If we have someone leaving the team, someone else will be able to take his work. 
To do that, there will be at least 2 people on each part. 
Also, we ask everyone to push their work every day so we don't lose any work done.

### Knowledge

Nobody in the team knows about Unity. To fix that, you have Sebastien Goisbeault as a teacher that can help.
Here is an exhaustive list of website to use too: 

- [Stack Overflow](https://stackoverflow.com/)
- [Unity Documentation](https://unity.com/fr)
- [C# Documentation](https://docs.microsoft.com/fr-fr/dotnet/csharp/)

## 7. Version 2.0

In the Version 2.0, we thought about adding those functionnalities : 
- You could be able to customise your avatar to make it like you. It could be more realistic for visitors
- Being able to interact with the different NPCs (talk, etc)
- Have an automated visit of the school
- Being able to train for an oral presentation and have feedback 
- Translations into other languages
- Add weather and day-night cycle
- Bug corrections and improved fluidity and stability
- Have a better resolution and image quality
- Being able to write and erase on the board in the classroom 
- Being able to control drones
- Being able to receive in real life what was bought in the simulation (If I buy a hoodie, I will receive it in real life)
- Add extern life (A car passing by, people walking, ...)
- Add the underground, the second floor and the rightest wing
- personalization of project rooms
- Add cameras and being able to see them in Franck office
- Add minigames in function of what they interact with (tennis table, chess...)
- Propose the simulation for open house days
- Extinct fire with the extinguisher
- Being able to take out the garbage
- If someone cuts himself with a knife, he has to use the emergency kit or he would have to go to the hospital and end the simulation
