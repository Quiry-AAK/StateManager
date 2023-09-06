using System;
using UnityEditor;
using UnityEngine;

namespace StateMachineGenerator.Editor.StateEditorClasses
{
    public class StatePropertiesWindow : EditorWindow
    {
        private SerializedProperty m_HasOnEnterProp;
        private SerializedProperty m_HasOnUpdateProp;
        private SerializedProperty m_HasOnFixedUpdateProp;
        private SerializedProperty m_HasOnExitProp;
        private SerializedProperty m_HasOnCollisionEnterProp;
        private SerializedProperty m_HasOnCollisionStayProp;
        private SerializedProperty m_HasOnCollisionExitProp;
        private SerializedProperty m_HasOnTriggerEnterProp;
        private SerializedProperty m_HasOnTriggerStayProp;
        private SerializedProperty m_HasOnTriggerExitProp;

        private StateEditorEventDrawer m_HasOnEnterPropDrawer;
        private StateEditorEventDrawer m_HasOnUpdatePropDrawer;
        private StateEditorEventDrawer m_HasOnFixedUpdatePropDrawer;
        private StateEditorEventDrawer m_HasOnExitPropDrawer;
        private StateEditorEventDrawer m_HasOnCollisionEnterPropDrawer;
        private StateEditorEventDrawer m_HasOnCollisionStayPropDrawer;
        private StateEditorEventDrawer m_HasOnCollisionExitPropDrawer;
        private StateEditorEventDrawer m_HasOnTriggerEnterPropDrawer;
        private StateEditorEventDrawer m_HasOnTriggerStayPropDrawer;
        private StateEditorEventDrawer m_HasOnTriggerExitPropDrawer;

        private SerializedProperty m_OnEnterEvent;
        private SerializedProperty m_OnUpdateEvent;
        private SerializedProperty m_OnFixedUpdateEvent;
        private SerializedProperty m_OnExitEvent;
        private SerializedProperty m_OnCollisionEnterEvent;
        private SerializedProperty m_OnCollisionStayEvent;
        private SerializedProperty m_OnCollisionExitEvent;
        private SerializedProperty m_OnTriggerEnterEvent;
        private SerializedProperty m_OnTriggerStayEvent;
        private SerializedProperty m_OnTriggerExitEvent;

        private SerializedProperty m_AllowedTransitionsProp;

        private static SerializedObject StateSerializedObject;

        private void OnEnable()
        {
            m_OnEnterEvent = StateSerializedObject.FindProperty("onEnterEvent");
            m_OnUpdateEvent = StateSerializedObject.FindProperty("onUpdateEvent");
            m_OnFixedUpdateEvent = StateSerializedObject.FindProperty("onFixedUpdateEvent");
            m_OnExitEvent = StateSerializedObject.FindProperty("onExitEvent");
            m_OnCollisionEnterEvent = StateSerializedObject.FindProperty("onCollisionEnterEvent");
            m_OnCollisionStayEvent = StateSerializedObject.FindProperty("onCollisionStayEvent");
            m_OnCollisionExitEvent = StateSerializedObject.FindProperty("onCollisionExitEvent");
            m_OnTriggerEnterEvent = StateSerializedObject.FindProperty("onTriggerEnterEvent");
            m_OnTriggerStayEvent = StateSerializedObject.FindProperty("onTriggerStayEvent");
            m_OnTriggerExitEvent = StateSerializedObject.FindProperty("onTriggerExitEvent");
            m_AllowedTransitionsProp = StateSerializedObject.FindProperty("allowedTransitions");
            
            m_HasOnEnterProp = StateSerializedObject.FindProperty("m_HasOnEnter");
            m_HasOnEnterPropDrawer = new StateEditorEventDrawer(StateSerializedObject, m_HasOnEnterProp, m_OnEnterEvent, "OnEnter");

            m_HasOnUpdateProp = StateSerializedObject.FindProperty("m_HasOnUpdate");
            m_HasOnUpdatePropDrawer = new StateEditorEventDrawer(StateSerializedObject, m_HasOnUpdateProp, m_OnUpdateEvent, "OnUpdate");

            m_HasOnFixedUpdateProp = StateSerializedObject.FindProperty("m_HasOnFixedUpdate");
            m_HasOnFixedUpdatePropDrawer = new StateEditorEventDrawer(StateSerializedObject, m_HasOnFixedUpdateProp, m_OnFixedUpdateEvent, "OnFixedUpdate");

            m_HasOnExitProp = StateSerializedObject.FindProperty("m_HasOnExit");
            m_HasOnExitPropDrawer = new StateEditorEventDrawer(StateSerializedObject, m_HasOnExitProp, m_OnExitEvent, "OnExit");

            m_HasOnCollisionEnterProp = StateSerializedObject.FindProperty("m_HasOnCollisionEnter");
            m_HasOnCollisionEnterPropDrawer = new StateEditorEventDrawer(StateSerializedObject, m_HasOnCollisionEnterProp, m_OnCollisionEnterEvent, "OnCollisionEnter");

            m_HasOnCollisionStayProp = StateSerializedObject.FindProperty("m_HasOnCollisionStay");
            m_HasOnCollisionStayPropDrawer = new StateEditorEventDrawer(StateSerializedObject, m_HasOnCollisionStayProp, m_OnCollisionStayEvent, "OnCollisionStay");

            m_HasOnCollisionExitProp = StateSerializedObject.FindProperty("m_HasOnCollisionExit");
            m_HasOnCollisionExitPropDrawer = new StateEditorEventDrawer(StateSerializedObject, m_HasOnCollisionExitProp, m_OnCollisionExitEvent, "OnCollisionExit");

            m_HasOnTriggerEnterProp = StateSerializedObject.FindProperty("m_HasOnTriggerEnter");
            m_HasOnTriggerEnterPropDrawer = new StateEditorEventDrawer(StateSerializedObject, m_HasOnTriggerEnterProp, m_OnTriggerEnterEvent, "OnTriggerEnter");

            m_HasOnTriggerStayProp = StateSerializedObject.FindProperty("m_HasOnTriggerStay");
            m_HasOnTriggerStayPropDrawer = new StateEditorEventDrawer(StateSerializedObject, m_HasOnTriggerStayProp, m_OnTriggerStayEvent, "OnTriggerStay");

            m_HasOnTriggerExitProp = StateSerializedObject.FindProperty("m_HasOnTriggerExit");
            m_HasOnTriggerExitPropDrawer = new StateEditorEventDrawer(StateSerializedObject, m_HasOnTriggerExitProp, m_OnTriggerExitEvent, "OnTriggerExit");
        }


        public static void MakeEnableGUI(SerializedObject stateSerializedObject)
        {
            StateSerializedObject = stateSerializedObject;
            GetWindow<StatePropertiesWindow>();
        }
        
        private void OnGUI()
        {
            StateSerializedObject.Update();
            m_HasOnEnterPropDrawer.OnInspector();
            m_HasOnUpdatePropDrawer.OnInspector();
            m_HasOnFixedUpdatePropDrawer.OnInspector();
            m_HasOnExitPropDrawer.OnInspector();
            m_HasOnCollisionEnterPropDrawer.OnInspector();
            m_HasOnCollisionStayPropDrawer.OnInspector();
            m_HasOnCollisionExitPropDrawer.OnInspector();
            m_HasOnTriggerEnterPropDrawer.OnInspector();
            m_HasOnTriggerStayPropDrawer.OnInspector();
            m_HasOnTriggerExitPropDrawer.OnInspector();
            EditorGUILayout.LabelField("Transitions", EditorStyles.boldLabel);
            EditorGUILayout.PropertyField(m_AllowedTransitionsProp);
            StateSerializedObject.ApplyModifiedProperties();
        }
    }
}
