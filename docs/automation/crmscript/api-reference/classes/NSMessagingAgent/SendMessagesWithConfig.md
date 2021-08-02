---
uid: crmscript_ref_NSMessagingAgent_SendMessagesWithConfig
title: NSMessageDeliveryStatus[] SendMessagesWithConfig(String plugin, NSOutgoingMessage[] outgoingMessages, StringDictionary config)
intellisense: NSMessagingAgent.SendMessagesWithConfig
keywords: NSMessagingAgent, SendMessagesWithConfig
so.topic: reference
---

Send an array of messages using given config

**Parameters:**
 - **plugin** Name of plugin to use.
 - **outgoingMessages** Array of outgoing messages you want to send.
 - **config** Config values used by the plugin.

**Returns:** NSMessageDeliveryStatus[]

```crmscript
NSMessagingAgent agent;
String plugin;
NSOutgoingMessage[] outgoingMessages;
StringDictionary config;
NSMessageDeliveryStatus[] res = agent.SendMessagesWithConfig(plugin, outgoingMessages, config);
```

