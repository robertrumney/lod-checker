# LOD Checker

A Unity Editor tool to detect and highlight LOD (Level of Detail) groups where child objects have misaligned transforms. Misaligned transforms can lead to visual inconsistencies and performance issues, making it harder for project managers and level editors to ensure quality and consistency across scenes.

## Why This Is Important

In many game development workflows, LOD groups are essential for optimizing scene performance by reducing the complexity of objects as they get farther away from the camera. However, a common issue occurs when child objects in LOD groups are accidentally moved, rotated, or scaled, creating unintended visual effects and performance degradation.

### Key Problems Solved:
- **Prevent Unintentional Transform Misalignments**: Unity's default behavior allows level editors to unintentionally manipulate child objects when they intend to move the parent LOD group. This tool helps catch those mistakes.
- **Reduce Manager-Editor Frustration**: Miscommunication happens when editors accidentally move child objects, and managers discover visual or performance issues later. This tool allows for early detection and quick fixes, minimizing project delays and misunderstandings.
- **Ensure Consistency and Optimization**: By detecting transform inconsistencies, the tool helps enforce a consistent standard across LOD groups, improving both visual quality and scene performance.

## How It Works

1. **Scan Scene for LOD Groups**: The tool scans the entire scene for all LOD groups.
2. **Detect Misaligned Transforms**: It identifies if any child within an LOD group has a local position, rotation, or scale that differs from its default values.
3. **Highlight Problematic LOD Groups**: The tool displays a list of LOD groups with misaligned children, allowing users to ping and easily locate them in the scene for quick fixes.

## How to Use

1. Clone the repository into your Unity project.
2. Open Unity and navigate to the **Tools** menu.
3. Select **LOD Transform Checker** from the list.
4. Click **Check LOD Groups** to view all LOD groups with misaligned children.
5. Use the **Ping** button to locate any problematic LOD groups and fix their transforms.

## Requirements

- Unity 2020.3 or higher
- C# scripting enabled in the project

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.
