---
uid: crmscript_ref_NSMessagingAgent_SendMessages
title: NSMessageDeliveryStatus[] SendMessages(String plugin, NSOutgoingMessage[] outgoingMessages)
intellisense: NSMessagingAgent.SendMessages
keywords: NSMessagingAgent, SendMessages
so.topic: reference
---

# NSMessageDeliveryStatus[] SendMessages(String plugin, NSOutgoingMessage[] outgoingMessages)

Send an array of messages

**Parameters:**
 - **plugin** Name of plugin to use.
 - **outgoingMessages** Array of outgoing messages you want to send.

**Returns:** NSMessageDeliveryStatus[]

```crmscript
NSMessagingAgent agent;
String plugin;
NSOutgoingMessage[] outgoingMessages;
NSMessageDeliveryStatus[] res = agent.SendMessages(plugin, outgoingMessages);
```

