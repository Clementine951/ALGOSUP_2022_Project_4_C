# Technical Specification

## Table of contents

- [1. Introduction](#1-introduction)

- [2. Team](#2-team)

- [3. Development rules](#3-development-rules)

- [4. Assets Used](#4-assets-used)

- [5. Choice of furnitures](#5-choice-of-furnitures)

- [6. Possible issues](#6-possible-issues)

- [7.Version 2.0 ](#7-version-2)

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



### B. Formating

| Type  | Format |
|:--------------- |:---------------:|
| Namespace | camelCase |
| Module | camelCase |
| Function  | PascalCase |
| Variable | PascalCase |


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
