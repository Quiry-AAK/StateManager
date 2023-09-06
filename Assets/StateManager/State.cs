using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace StateMachineGenerator
{
    [RequireComponent(typeof(StateManager))]
    public class State : MonoBehaviour
    {
        [SerializeField] private UnityEvent onEnterEvent;
        [SerializeField] private UnityEvent onUpdateEvent;
        [SerializeField] private UnityEvent onFixedUpdateEvent;
        [SerializeField] private UnityEvent onExitEvent;
        [SerializeField] private UnityEvent<Collision> onCollisionEnterEvent;
        [SerializeField] private UnityEvent<Collision> onCollisionStayEvent;
        [SerializeField] private UnityEvent<Collision> onCollisionExitEvent;
        [SerializeField] private UnityEvent<Collider> onTriggerEnterEvent;
        [SerializeField] private UnityEvent<Collider> onTriggerStayEvent;
        [SerializeField] private UnityEvent<Collider> onTriggerExitEvent;

        [SerializeField] private string stateName;
        [SerializeField] private List<string> allowedTransitions;

        // EditorValues
        [SerializeField] private bool m_HasOnEnter;
        [SerializeField] private bool m_HasOnUpdate;
        [SerializeField] private bool m_HasOnFixedUpdate;
        [SerializeField] private bool m_HasOnExit;
        [SerializeField] private bool m_HasOnCollisionEnter;
        [SerializeField] private bool m_HasOnCollisionStay;
        [SerializeField] private bool m_HasOnCollisionExit;
        [SerializeField] private bool m_HasOnTriggerEnter;
        [SerializeField] private bool m_HasOnTriggerStay;
        [SerializeField] private bool m_HasOnTriggerExit;

        #region Props

        public string StateName => stateName;

        public List<string> AllowedTransitions => allowedTransitions;

        public UnityEvent OnEnterEvent => onEnterEvent;

        public UnityEvent OnUpdateEvent => onUpdateEvent;

        public UnityEvent OnFixedUpdateEvent => onFixedUpdateEvent;

        public UnityEvent OnExitEvent => onExitEvent;

        public UnityEvent<Collision> OnCollisionEnterEvent => onCollisionEnterEvent;

        public UnityEvent<Collision> OnCollisionStayEvent => onCollisionStayEvent;

        public UnityEvent<Collision> OnCollisionExitEvent => onCollisionExitEvent;

        public UnityEvent<Collider> OnTriggerEnterEvent => onTriggerEnterEvent;

        public UnityEvent<Collider> OnTriggerStayEvent => onTriggerStayEvent;

        public UnityEvent<Collider> OnTriggerExitEvent => onTriggerExitEvent;

        #endregion
    }
}
