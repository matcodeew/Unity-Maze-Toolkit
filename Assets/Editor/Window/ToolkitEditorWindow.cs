using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace Matcodeew.Maze_Toolkit
{
    internal class ToolkitEditorWindow : EditorWindow
    {
        private IntegerField widthField;
        private IntegerField heightField;
        private Button createGridButton;

        [MenuItem("Tools/Maze Toolkit")]
        public static void OpenWindow()
        {
            ToolkitEditorWindow window =
                GetWindow<ToolkitEditorWindow>();

            window.titleContent =
                new GUIContent("Maze Toolkit");
        }

        public void CreateGUI()
        {
            if (!LoadAsset(
                "Assets/Editor/Window/EditorWindowVisualTree.uxml",
                out VisualTreeAsset visualTree))
            {
                return;
            }

            visualTree.CloneTree(rootVisualElement);

            BindElements();
            RegisterCallbacks();
        }

        private void BindElements()
        {
            widthField =
                rootVisualElement.Q<IntegerField>("width-field");

            heightField =
                rootVisualElement.Q<IntegerField>("height-field");

            createGridButton =
                rootVisualElement.Q<Button>("create-grid-button");
        }

        private void RegisterCallbacks()
        {
            createGridButton.clicked += OnCreateGridClicked;
        }

        private void OnCreateGridClicked()
        {
            Debug.Log(
                $"Create {widthField.value}x{heightField.value}");
        }

        private bool LoadAsset(
            string path,
            out VisualTreeAsset asset)
        {
            asset =
                AssetDatabase.LoadAssetAtPath<VisualTreeAsset>(path);

            if (asset != null)
                return true;

            Debug.LogError(
                $"Maze Toolkit: Unable to load asset at {path}");

            return false;
        }
    }
}