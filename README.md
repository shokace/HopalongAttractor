# Unity Particle Animation with Hopalong Attractor Algorithm

## Overview
This project includes scripts to animate particles in Unity using the Hopalong Attractor algorithm. The particles' behavior and trajectories are dynamically generated to create visually engaging patterns.

## Scripts

### ObjectSpawner.cs
- **Functionality**: Manages the spawning and life cycle of particles based on the Hopalong Attractor.
- **Key Features**:
  - Dynamically modifies trajectory parameters (`Mutators`) to vary particle patterns.
  - Uses coroutines to manage continuous spawning and orbit calculations.

### ParticleSpawner.cs
- **Functionality**: Spawns a single particle at the start of the scene.
- **Key Features**:
  - Instantiates a particle at a set position with predefined rotation and scale.

### PlaneMovement.cs
- **Functionality**: Controls the upward movement of a GameObject, destroying it if it moves beyond a preset boundary.
- **Key Features**:
  - Simple movement script with boundary-based destruction for cleaning up out-of-bound objects.

## Setup
- Import the scripts into your Unity project.
- Attach `ObjectSpawner.cs` to a GameObject to manage particle spawning.
- Attach `ParticleSpawner.cs` and `PlaneMovement.cs` to other GameObjects as needed based on your scene setup.

## Usage
- Adjust parameters within the scripts to fine-tune particle behaviors and movement speeds.
- Combine with other effects and GameObjects to create complex animations and interactions in your Unity scene.
