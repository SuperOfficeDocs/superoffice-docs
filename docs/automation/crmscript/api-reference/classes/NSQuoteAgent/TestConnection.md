---
uid: crmscript_class_nsquoteagent_testconnection
title: PluginResponse TestConnection()
description: CRMScript method in the NSQuoteAgent class
intellisense: NSQuoteAgent.TestConnection
keywords: NSQuoteAgent, TestConnection, TestConnection(String,StringDictionary)
so.topic: reference
---

# TestConnection()

Used by the Admin clients. Testing if the connection data is sufficient to get a connection with the ERP system. The Connector should try to do some operations to check if the connection has sufficient rights to run. The connection has not been created yet. `TestConnection()` is called without InitializeConnector being called first.

Returns how the test went

`PluginResponse TestConnection(String connectorName, StringDictionary connectionData)`

## Parameters

| connectorName | String | Name of the connector. |
| connectionData | StringDictionary | The name-value collection of the configuration data requested to create a connection |

## Exxamples

```crmscript
NSQuoteAgent agent;
String connectorName;
StringDictionary connectionData;
PluginResponse res = agent.TestConnection(connectorName, connectionData);
```
