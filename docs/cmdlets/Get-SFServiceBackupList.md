# Get-SFServiceBackupList
Gets the list of backups available for every partition in this service.
## Description

Returns a list of backups available for every partition in this Service Fabric service. The server enumerates all the 
backups available in the backup store configured in the backup policy. It also allows filtering of the result based on 
start and end datetime or just fetching the latest available backup for every partition.



## Optional Parameters
#### -ServerTimeout

The server timeout for performing the operation in seconds. This timeout specifies the time duration that the client 
is willing to wait for the requested operation to complete. The default value for this parameter is 60 seconds.



#### -Latest

Specifies whether to get only the most recent backup available for a partition for the specified time range.



#### -StartDateTimeFilter

Specify the start date time from which to enumerate backups, in datetime format. The date time must be specified in 
ISO8601 format. This is an optional parameter. If not specified, all backups from the beginning are enumerated.



#### -EndDateTimeFilter

Specify the end date time till which to enumerate backups, in datetime format. The date time must be specified in 
ISO8601 format. This is an optional parameter. If not specified, enumeration is done till the most recent backup.



#### -MaxResults

The maximum number of results to be returned as part of the paged queries. This parameter defines the upper bound on 
the number of results returned. The results returned can be less than the specified maximum results if they do not fit 
in the message as per the max message size restrictions defined in the configuration. If this parameter is zero or not 
specified, the paged query includes as many results as possible that fit in the return message.



