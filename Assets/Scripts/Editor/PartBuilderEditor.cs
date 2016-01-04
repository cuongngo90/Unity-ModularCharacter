using UnityEngine;
using UnityEditor;
using System.Collections;

[CustomEditor(typeof(PartBuilder))]
public class PartBuilderEditor : Editor {

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        PartBuilder part = (PartBuilder)target;

        if (GUILayout.Button("Build all part"))
        {
            part.BuildAllPart();
        }
    }
}
