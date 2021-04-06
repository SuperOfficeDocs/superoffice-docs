---
uid: crmscript_ref_NSQuoteAgent_TestConnection
title: PluginResponse TestConnection(String connectorName, StringDictionary connectionData)
intellisense: NSQuoteAgent.TestConnection
keywords: NSQuoteAgent, TestConnection
so.topic: reference
---

Used by the Admin clients. Testing if the connection data is sufficient to get a connection with the ERP system. The Connector should try to do some operations to check if the connection has sufficient rights to run. The connection has not been created yet. TestConnection is called without InitializeConnector being called first.

**Parameters:**
 - **connectorName** Name of the connector.
 - **connectionData** Basically the name/value collection of the configuration data requested to create a connection

**Returns:** How the test went

```crmscript
NSQuoteAgent agent;
String connectorName;
StringDictionary connectionData;
PluginResponse res = agent.TestConnection(connectorName, connectionData);
```

