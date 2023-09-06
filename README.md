# StateManager
Simple state manager to apply state design pattern easily.
![image](https://github.com/Quiry-AAK/StateManager/assets/76917305/0be04bee-1735-439c-ad24-83b1726d3f82)

To change state you have to add the new state into the current state transitions.
Then, get StateManager script via GetComponent<StateManager>() or SerializeField and use the ChangeStateIfItsPossible method
![image](https://github.com/Quiry-AAK/StateManager/assets/76917305/6ecb840b-7326-47ac-828a-161056f4dcb8)
Or, you can override state by using ChangeStateByOverriding method. This method doesn't check the transition list and overrides state.
![image](https://github.com/Quiry-AAK/StateManager/assets/76917305/ee2d2beb-9a87-433f-870f-dc4f264a0274)
