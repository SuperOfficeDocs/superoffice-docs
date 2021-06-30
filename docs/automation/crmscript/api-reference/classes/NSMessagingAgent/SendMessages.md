---
uid: crmscript_ref_NSMessagingAgent_SendMessages
title: MessageDeliveryStatus[] SendMessages(String plugin, OutgoingMessage[] outgoingMessages)
intellisense: NSMessagingAgent.SendMessages
keywords: NSMessagingAgent, SendMessages
so.topic: reference
---

Send an array of messages

**Parameters:**
 - **plugin** Name of plugin to use.
 - **outgoingMessages** Array of outgoing messages you want to send.

**Returns:** Array of MessageDeliveryStatus. Length of the array is equal to the number of outgoing messages.

```crmscript
NSMessagingAgent agent;
String plugin;
OutgoingMessage[] outgoingMessages;
MessageDeliveryStatus[] res = agent.SendMessages(plugin, outgoingMessages);
```

