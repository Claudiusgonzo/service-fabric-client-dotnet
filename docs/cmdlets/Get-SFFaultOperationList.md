# Get-SFFaultOperationList
Gets a list of user-induced fault operations filtered by provided input.
## Description

Gets the list of user-induced fault operations filtered by provided input.



## Required Parameters
#### -TypeFilter

Used to filter on OperationType for user-induced operations.
                    
                    - 65535 - select all
                    - 1 - select PartitionDataLoss.
                    - 2 - select PartitionQuorumLoss.
                    - 4 - select PartitionRestart.
                    - 8 - select NodeTransition.



#### -StateFilter

Used to filter on OperationState's for user-induced operations.
                    
                    - 65535 - select All
                    - 1 - select Running
                    - 2 - select RollingBack
                    - 8 - select Completed
                    - 16 - select Faulted
                    - 32 - select Cancelled
                    - 64 - select ForceCancelled



