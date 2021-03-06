# Get-SFClusterManifest
Get the Service Fabric cluster manifest.
## Description

Get the Service Fabric cluster manifest. The cluster manifest contains properties of the cluster that include 
different node types on the cluster,
                security configurations, fault, and upgrade domain topologies, etc.
                
                These properties are specified as part of the ClusterConfig.JSON file while deploying a stand-alone 
cluster. However, most of the information in the cluster manifest
                is generated internally by service fabric during cluster deployment in other deployment scenarios 
(e.g. when using Azure portal).
                
                The contents of the cluster manifest are for informational purposes only and users are not expected to 
take a dependency on the format of the file contents or its interpretation.



