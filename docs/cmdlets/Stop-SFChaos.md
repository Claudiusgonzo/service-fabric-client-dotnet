# Stop-SFChaos
Stops Chaos if it is running in the cluster and put the Chaos Schedule in a stopped state.
## Description

Stops Chaos from executing new faults. In-flight faults will continue to execute until they are complete. The current 
Chaos Schedule is put into a stopped state.
                Once a schedule is stopped, it will stay in the stopped state and not be used to Chaos Schedule new 
runs of Chaos. A new Chaos Schedule must be set in order to resume scheduling.



