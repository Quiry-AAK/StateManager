using UnityEditor;
using UnityEngine;

namespace StateMachineGenerator.Editor.StateEditorClasses
{
    public class StateEditorEventDrawer
    {
        private string label;
        private SerializedObject so;
        private SerializedProperty spBool;
        private SerializedProperty spEvent;
        public StateEditorEventDrawer(SerializedObject so, SerializedProperty spBool, SerializedProperty spEvent, string label)
        {
            this.so = so;
            this.spBool = spBool;
            this.label = label;
            this.spEvent = spEvent;
        }
        public void OnInspector()
        {
            EditorGUILayout.PropertyField(spBool, new GUIContent(label));
            if (spBool.boolValue) {
                EditorGUILayout.PropertyField(spEvent);
            }
        }
    }
}
