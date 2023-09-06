using System;
using StateMachineGenerator.Editor.StateEditorClasses;
using UnityEngine;
using UnityEditor;

namespace StateMachineGenerator.Editor
{
    [CustomEditor(typeof(State))]
    [CanEditMultipleObjects]
    public class StateEditor : UnityEditor.Editor
    {
        private SerializedProperty m_StateNameProp;
        
        private void OnEnable()
        {
            m_StateNameProp = serializedObject.FindProperty("stateName");
        }

        public override void OnInspectorGUI()
        {
            var _buttonStyle = new GUIStyle(GUI.skin.button);
            _buttonStyle.normal.textColor = Color.green;
            _buttonStyle.active.textColor = Color.green;
            _buttonStyle.fontSize = 18;
            
            serializedObject.Update();
            EditorGUILayout.PropertyField(m_StateNameProp);
            
            if(GUILayout.Button("Adjust Properties", _buttonStyle, GUILayout.ExpandWidth(true), GUILayout.Height(30)))
            {
                StatePropertiesWindow.MakeEnableGUI(serializedObject);
            }
            serializedObject.ApplyModifiedProperties();
        }
    }
}
