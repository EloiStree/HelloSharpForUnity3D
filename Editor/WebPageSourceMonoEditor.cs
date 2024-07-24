using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(WebPageSourceMono))]
public class WebPageSourceMonoEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        WebPageSourceMono script = (WebPageSourceMono)target;
        if (GUILayout.Button("Open Documentation"))
        {
            string url = script.GetSourceUrl();
            Application.OpenURL(url);
        }
    }
}