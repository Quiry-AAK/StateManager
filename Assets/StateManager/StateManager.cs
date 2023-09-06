using System;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace StateMachineGenerator
{
    public class StateManager : MonoBehaviour
    {
        private State currentState;

        [SerializeField] private State initialState;

        private State[] allStates;

        private Dictionary<string, State> stateDictionary = new Dictionary<string, State>();

        public State CurrentState => currentState;

        private void Awake()
        {
            allStates = GetComponents<State>();
            foreach (var _state in allStates) {
                stateDictionary.Add(_state.StateName, _state);
            }
            
            currentState = initialState;
        }
        public void Start()
        {
            currentState.OnEnterEvent?.Invoke();
        }

        private void Update()
        {
            currentState.OnUpdateEvent?.Invoke();
        }
        private void FixedUpdate()
        {
            currentState.OnFixedUpdateEvent?.Invoke();
        }

        private void OnCollisionEnter(Collision other)
        {
            currentState.OnCollisionEnterEvent?.Invoke(other);
        }

        private void OnCollisionStay(Collision other)
        {
            currentState.OnCollisionStayEvent?.Invoke(other);
        }

        private void OnCollisionExit(Collision other)
        {
            currentState.OnCollisionExitEvent?.Invoke(other);
        }

        private void OnTriggerEnter(Collider other)
        {
            currentState.OnTriggerEnterEvent?.Invoke(other);
        }

        private void OnTriggerStay(Collider other)
        {
            currentState.OnTriggerStayEvent?.Invoke(other);
        }

        private void OnTriggerExit(Collider other)
        {
            currentState.OnTriggerExitEvent?.Invoke(other);
        }

        public void ChangeStateIfItsPossible(string newStateName)
        {
            var _canChange = currentState.AllowedTransitions.Any(_transition => _transition == newStateName);
            if (!_canChange) return;
            var _newState = stateDictionary[newStateName];
            if (_newState == null) {
                Debug.LogError("Invalid state name for transition !!!");
                return;
            }
            
            currentState.OnExitEvent?.Invoke();
            currentState = _newState; 
            currentState.OnEnterEvent?.Invoke();
        }

        public void ChangeStateByOverriding(string newStateName)
        {
            var _newState = stateDictionary[newStateName];
            if (_newState == null) {
                Debug.LogError("Invalid state name for transition !!!");
                return;
            }

            currentState.OnExitEvent?.Invoke();
            currentState = _newState; 
            currentState.OnEnterEvent?.Invoke();
        }
    }
}
