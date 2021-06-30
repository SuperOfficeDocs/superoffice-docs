---
uid: crmscript_ref_NSMessagingAgent_SendMessagesWithConfig
title: MessageDeliveryStatus[] SendMessagesWithConfig(String plugin, OutgoingMessage[] outgoingMessages, StringDictionary config)
intellisense: NSMessagingAgent.SendMessagesWithConfig
keywords: NSMessagingAgent, SendMessagesWithConfig
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
OutgoingMessage[] outgoingMessages;
StringDictionary config;
MessageDeliveryStatus[] res = agent.SendMessagesWithConfig(plugin, outgoingMessages, config);
```

