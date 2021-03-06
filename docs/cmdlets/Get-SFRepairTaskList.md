# Get-SFRepairTaskList
Gets a list of repair tasks matching the given filters.
## Description

This API supports the Service Fabric platform; it is not meant to be used directly from your code.



## Optional Parameters
#### -TaskIdFilter

The repair task ID prefix to be matched.



#### -StateFilter

A bitwise-OR of the following values, specifying which task states should be included in the result list.
                    
                    - 1 - Created
                    - 2 - Claimed
                    - 4 - Preparing
                    - 8 - Approved
                    - 16 - Executing
                    - 32 - Restoring
                    - 64 - Completed



#### -ExecutorFilter

The name of the repair executor whose claimed tasks should be included in the list.



