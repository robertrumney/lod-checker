using UnityEditor;
using UnityEngine;

public class LODTransformChecker : EditorWindow
{
    // Window menu item
    [MenuItem("Tools/LOD Transform Checker")]
    public static void ShowWindow()
    {
        GetWindow<LODTransformChecker>("LOD Transform Checker");
    }

    private Vector2 scrollPos;
    
    // Method to find all LOD groups in the scene
    private void OnGUI()
    {
        GUILayout.Label("LOD Groups with Misaligned Children", EditorStyles.boldLabel);
        
        if (GUILayout.Button("Check LOD Groups"))
        {
            CheckLODGroups();
        }
        
        scrollPos = GUILayout.BeginScrollView(scrollPos, GUILayout.Width(position.width), GUILayout.Height(position.height - 50));
        
        foreach (var lodGroup in FindObjectsOfType<LODGroup>())
        {
            Transform parentTransform = lodGroup.transform;
            bool isMisaligned = false;

            foreach (Transform child in parentTransform)
            {
                if (child.localPosition != Vector3.zero || child.localRotation != Quaternion.identity || child.localScale != Vector3.one)
                {
                    isMisaligned = true;
                    break;
                }
            }

            if (isMisaligned)
            {
                // Show LOD Group in the list
                GUILayout.BeginHorizontal();
                GUILayout.Label(lodGroup.name);

                if (GUILayout.Button("Ping"))
                {
                    EditorGUIUtility.PingObject(lodGroup.gameObject);
                }
                GUILayout.EndHorizontal();
            }
        }

        GUILayout.EndScrollView();
    }

    // Check for misaligned LOD Groups
    private void CheckLODGroups()
    {
        foreach (var lodGroup in FindObjectsOfType<LODGroup>())
        {
            Transform parentTransform = lodGroup.transform;
            bool isMisaligned = false;

            foreach (Transform child in parentTransform)
            {
                if (child.localPosition != Vector3.zero || child.localRotation != Quaternion.identity || child.localScale != Vector3.one)
                {
                    isMisaligned = true;
                    break;
                }
            }

            if (isMisaligned)
            {
                Debug.LogWarning("Misaligned LOD Group: " + lodGroup.name, lodGroup.gameObject);
            }
        }
    }
}
