using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(MIDIPianoPlayer))]
public class MIDIKeyAutoAssignEditor : Editor
{

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        var script = (MIDIPianoPlayer)target;

         if (GUILayout.Button("Auto Assign and configure keys"))
        {
            script.SetupKeys();
            EditorUtility.SetDirty(script); 
        }
    }
}
