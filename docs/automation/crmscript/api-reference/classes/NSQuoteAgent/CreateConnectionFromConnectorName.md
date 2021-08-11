---
uid: crmscript_ref_NSQuoteAgent_CreateConnectionFromConnectorName
title: NSQuoteConnection CreateConnectionFromConnectorName(String connectorName)
intellisense: NSQuoteAgent.CreateConnectionFromConnectorName
keywords: NSQuoteAgent, CreateConnectionFromConnectorName
so.topic: reference
---

# NSQuoteConnection CreateConnectionFromConnectorName(String connectorName)

Create a new connection.

**Parameters:**
 - **connectorName** The name of the connector to create this connection for.

**Returns:** NSQuoteConnection

```crmscript
NSQuoteAgent agent;
String connectorName;
NSQuoteConnection res = agent.CreateConnectionFromConnectorName(connectorName);
```

