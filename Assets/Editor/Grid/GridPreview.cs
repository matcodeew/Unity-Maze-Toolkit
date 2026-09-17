using UnityEngine;
using UnityEngine.UIElements;

public class GridPreview
{
    private readonly MazeEditorContext context;

    private readonly VisualElement root;

    private readonly VisualElement gridBackground;
    private readonly Label zoomLabel;

    public GridPreview(VisualElement root, MazeEditorContext context)
    {
        this.root = root;
        this.context = context;

        context.OnContextPushed += OnContextChanged;

        gridBackground =
            root.Q<VisualElement>("GridPreviewBackground");

        zoomLabel =
            root.Q<Label>("ZoomLabel");

        gridBackground.generateVisualContent += DrawGrid;


        UpdateZoomLabel();
    }

    private void UpdateZoomLabel()
    {
        // exemple
        // zoomLabel.text = $"{context.Zoom * 100:F0}%";
        float zoom = 100;
        zoomLabel.text = $"zoom : {zoom}%";
    }

    private void OnContextChanged(MazeEditorContext context)
    {
        gridBackground.MarkDirtyRepaint();
    }

    private void DrawGrid(MeshGenerationContext meshContext)
    {
        Painter2D painter = meshContext.painter2D;

        painter.strokeColor = Color.gray;
        painter.lineWidth = 1f;

        float width = context.Width * context.CellSize;
        float height = context.Height * context.CellSize;

        for (int x = 0; x <= context.Width; x++)
        {
            float posX = x * context.CellSize;

            painter.BeginPath();
            painter.MoveTo(new Vector2(posX, 0));
            painter.LineTo(new Vector2(posX, height));
            painter.Stroke();
        }

        for (int y = 0; y <= context.Height; y++)
        {
            float posY = y * context.CellSize;

            painter.BeginPath();
            painter.MoveTo(new Vector2(0, posY));
            painter.LineTo(new Vector2(width, posY));
            painter.Stroke();
        }
    }
}