---
title: NSPluginResponse TestConnection(String connectorName, StringDictionary connectionData)
path: /EJScript/Classes/NSQuoteAgent/Member functions/NSPluginResponse TestConnection(String p_0, StringDictionary p_1)
intellisense: 1
classref: 1
keywords: TestConnection(String,StringDictionary)
---


Used by the Admin clients. Testing if the connection data is sufficient to get a connection with the ERP system. The Connector should try to do some operations to check if the connection has sufficient rights to run. The connection has not been created yet. TestConnection is called without InitializeConnector being called first.



* **connectorName:** Name of the connector.
* **connectionData:** Basically the name/value collection of the configuration data requested to create a connection
* **Returns:** How the test went


