using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(KeywordRedirectionMono))]
public class KeywordRedirectionMonoEditor : Editor
{
    public override void OnInspectorGUI()
    {
        // Draw the default inspector
        DrawDefaultInspector();

        // Get the target script
        KeywordRedirectionMono script = (KeywordRedirectionMono)target;

        // Ensure there are keywords to display
        if (!string.IsNullOrEmpty(script.m_keywordsSplitByComma))
        {
            // Split the keywords by comma
            string[] keywords = script.m_keywordsSplitByComma.Split(',');

            // Display buttons for each keyword
            foreach (string keyword in keywords)
            {
                string trimmedKeyword = keyword.Trim();

                // Horizontal layout for the buttons
                EditorGUILayout.BeginHorizontal();
                EditorGUILayout.LabelField(trimmedKeyword, GUILayout.Width(150));

                if (GUILayout.Button("Google"))
                {
                    Application.OpenURL("https://www.google.com/search?q=" + trimmedKeyword);
                }

                if (GUILayout.Button("YouTube"))
                {
                    Application.OpenURL("https://www.youtube.com/results?search_query=" + trimmedKeyword);
                }

                EditorGUILayout.EndHorizontal();
            }
        }
    }
}
