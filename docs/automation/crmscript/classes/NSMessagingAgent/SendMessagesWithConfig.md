---
title: crmscript_ref_NSMessagingAgent_SendMessagesWithConfig
description: MessageDeliveryStatusArray SendMessagesWithConfig(String plugin, OutgoingMessageArray outgoingMessages, StringDictionary config)
intellisense: NSMessagingAgent.SendMessagesWithConfig
keywords: NSMessagingAgent,SendMessagesWithConfig
so.topic: reference
---

Send an array of messages using given config

**Parameters:**
 - **plugin** Name of plugin to use.
 - **outgoingMessages** Array of outgoing messages you want to send.
 - **config** Config values used by the plugin.

**Returns:** Array of MessageDeliveryStatus. Length of the array is equal to the number of outgoing messages.

```crmscript
NSMessagingAgent agent;
String plugin;
OutgoingMessageArray outgoingMessages;
StringDictionary config;
MessageDeliveryStatusArray res = agent.SendMessagesWithConfig(plugin, outgoingMessages, config);
```

