using System;
using UnityEngine;
using UnityEngine.Events;
public class MazeEditorContext
{
    public event Action<MazeEditorContext> OnContextPushed;
    public void Push()
    {
        OnContextPushed?.Invoke(this);
    }
    
    public int Width { get; set; }
    public int Height { get; set; }

    public float CellSize { get; set; }

    public MazeEditorContext(int width, int heigth, float cellSize)
    {
        Width = width;
        Height = heigth;
        CellSize = cellSize;
    }
}
