# Space Shooter Game

A 2D space shooter game built with Unity where players control a spacecraft, shoot lasers, and avoid enemies.

## Features

- Player movement with WASD or arrow keys
- Player boundaries to keep the ship in game area
- Laser shooting mechanics with spacebar
- Enemy spawning and movement
- Collision detection between lasers and enemies

## Controls

- **Movement**:
  - W/Up Arrow: Move up
  - S/Down Arrow: Move down
  - A/Left Arrow: Move left
  - D/Right Arrow: Move right
- **Shooting**:
  - Spacebar: Fire laser

## Technical Details

### Player Movement

- Movement speed: 7.5 units/second
- X-axis boundaries: -8.0 to 8.0
- Y-axis boundaries: -3.5 to 0

### Laser Properties

- Speed: 10 units/second
- Spawns slightly above player (1.465 units)
- Auto-destroys when reaching Y = 8.5

### Enemy Properties

- Movement speed: 5 units/second
- X-axis spawn range: -7.5 to 7.5
- Respawns at top when reaching bottom of screen

## Requirements

- Unity 2022.3 or later
- Input System package
- 2D Feature Set

## Project Structure

- `Assets/Scripts/`
  - [`PlayerScript.cs`](Assets/Scripts/PlayerScript.cs): Player movement and shooting
  - [`LaserScript.cs`](Assets/Scripts/LaserScript.cs): Laser movement and destruction
  - [`EnemyScript.cs`](Assets/Scripts/EnemyScript.cs): Enemy behavior and collisions

## Setup

1. Clone the repository
2. Open the project in Unity
3. Open the main scene in `Assets/Scenes/`
4. Press Play to test the game

## Development

This project uses standard Unity development practices:

- MonoBehaviour scripts for game objects
- Physics2D for collision detection
- SerializeField for Unity Inspector configuration
