---
title: crmscript_ref_NSQuoteAgent_CreateConnectionFromConnectorName
description: QuoteConnection CreateConnectionFromConnectorName(String connectorName)
intellisense: NSQuoteAgent.CreateConnectionFromConnectorName
keywords: NSQuoteAgent,CreateConnectionFromConnectorName
so.topic: reference
---

Create a new connection.

**Parameters:**
 - **connectorName** The name of the connector to create this connection for.

**Returns:** The created connection

```crmscript
NSQuoteAgent agent;
String connectorName;
QuoteConnection res = agent.CreateConnectionFromConnectorName(connectorName);
```

