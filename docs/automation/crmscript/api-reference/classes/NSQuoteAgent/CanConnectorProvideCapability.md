---
uid: crmscript_ref_NSQuoteAgent_CanConnectorProvideCapability
title: Bool CanConnectorProvideCapability(Integer quoteConnectionId, String capabilityName)
intellisense: NSQuoteAgent.CanConnectorProvideCapability
keywords: NSQuoteAgent, CanConnectorProvideCapability
so.topic: reference
---

# Bool CanConnectorProvideCapability(Integer quoteConnectionId, String capabilityName)

Can the connector provide the capability

**Parameters:**
 - **quoteConnectionId** Primary key of the connection
 - **capabilityName** Capability name

**Returns:** Bool

```crmscript
NSQuoteAgent agent;
Integer quoteConnectionId;
String capabilityName;
Bool res = agent.CanConnectorProvideCapability(quoteConnectionId, capabilityName);
```

