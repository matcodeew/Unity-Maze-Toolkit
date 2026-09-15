# Unity Maze Toolkit

> An extensible Unity Editor toolkit for designing, generating and building grid-based procedural levels.

**Unity Maze Toolkit** is a Unity package designed to provide a visual and extensible workflow for creating grid-based levels directly inside the Unity Editor.

The project combines a visual grid editor, procedural generation algorithms and a modular generation pipeline. Developers can use the built-in tools or implement their own generation steps without modifying the toolkit's core.

> **Project Status:** Early Development

## Goals

* Visual grid-based level editor
* Cell painting and selection tools
* Procedural maze generation
* Seed-based deterministic generation
* Modular generation pipeline
* Custom generation algorithms
* Rooms and zones
* Automatic and manual chunk management
* Spawn points and gameplay markers
* Configurable visual themes
* Generation of Unity scenes from grid data

## Extensible Generation

The toolkit is designed around independent generation steps.

```text
Grid
 ↓
Generation Step
 ↓
Generation Step
 ↓
Generation Step
 ↓
Generated Level Data
 ↓
Scene Builder
 ↓
Unity Scene
```

Custom algorithms will be able to integrate with the toolkit by implementing a generation step.

```csharp
public class MyGenerationStep : MazeGenerationStep
{
    public override void Execute(
        MazeGrid grid,
        MazeGenerationContext context)
    {
        // Custom generation logic
    }
}
```

This makes it possible to integrate different approaches such as maze algorithms, room generation, cellular automata or Wave Function Collapse without modifying the toolkit itself.

## Roadmap

### v0.1 — Grid Editor

* Unity Editor window
* Grid creation and resizing
* Interactive grid preview
* Cell selection
* Basic painting tools

### v0.2 — Level Authoring

* Cell types
* Rooms and zones
* Advanced selection tools
* Grid asset saving

### v0.3 — Procedural Generation

* Generation pipeline
* Seed system
* Depth-First Search maze generation
* Custom generation step API

### v0.4 — Scene Generation

* Floor and wall generation
* Visual themes
* Mesh generation
* Scene builder

### v0.5 — Chunk System

* Automatic chunks
* Manual chunk editing
* Chunk visualization

### v1.0 — First Stable Release

* Extensible generation API
* Spawn system
* Documentation
* Samples
* Tests
* Unity Package Manager installation

## Architecture

The project separates level data, procedural generation, scene building and editor tooling.

```text
Maze Toolkit
│
├── Core
│   └── Grid / Cells / Zones
│
├── Generation
│   ├── Generation Pipeline
│   └── Built-in Algorithms
│
├── Rendering
│   └── Scene / Mesh Generation
│
└── Editor
    ├── Grid Editor
    ├── Tools
    └── UI
```

This separation allows generation algorithms to manipulate level data independently from the Unity Editor interface or final scene representation.

## Installation

Unity Maze Toolkit is currently under development and is not yet recommended for production use.

Unity Package Manager installation instructions will be provided with the first public release.

## License

License information will be added before the first public release.
